using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace pract3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int TrackIndex = 0;
        public bool PlayPause = true;
        public bool Repeat = false;
        private bool isRandom = false;
        public bool ignoreMusicSlidChange = false;
        public List<string> originalOrder; 
        public List<string> FullNameTrack = new List<string>();
        List<FileInfo> TrackForHistory = new List<FileInfo>();
        public DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromTicks(1); 
            timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (media.NaturalDuration.HasTimeSpan == true)
            {
                ignoreMusicSlidChange = true;
                musicSlid.Value = media.Position.Ticks;
                ignoreMusicSlidChange = false;
                CurrentTime.Content = media.Position.Seconds;
                AllTime.Content = $"{media.NaturalDuration.TimeSpan:mm\\:ss}";
                CurrentTime.Content = $"{media.Position:mm\\:ss}";
            }
        }
        private void AddInHistory(FileInfo FilePath)
        {
            TrackForHistory.Add(FilePath);
        }

        private void openDir_Click(object sender, RoutedEventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog() {IsFolderPicker = true };
            var result = dialog.ShowDialog();
            if (result == CommonFileDialogResult.Ok)
            {
                playlist.Items.Clear();
                FullNameTrack.Clear();
                TrackIndex = 0; 

                string[] files = Directory.GetFiles(dialog.FileName);
                foreach (string file in files)
                {
                    if (file.EndsWith(".mp3") || file.EndsWith(".wav") || file.EndsWith(".m4a") || file.EndsWith(".midi") || file.EndsWith(".ogg"))
                    {
                        FullNameTrack.Add(file); 
                        string fileName = System.IO.Path.GetFileName(file);
                        playlist.Items.Add(fileName);
                    }
                }
                if (playlist.Items.Count > 0)
                {
                    string selectedFilePath = System.IO.Path.Combine(dialog.FileName, playlist.Items[0].ToString());
                    media.Source = new Uri(selectedFilePath);
                    media.Play();
                    AddInHistory(new FileInfo(System.IO.Path.GetFileName(selectedFilePath)));
                }
            }
        }

        private void ShowHistory_Click(object sender, RoutedEventArgs e)
        {
            HistoryWindow historywin = new HistoryWindow();
            historywin.hist.ItemsSource = TrackForHistory;
            bool? result = historywin.ShowDialog();

            if (result == true)
            {
                string selectedFileName = historywin.FilePath;
                string selectedFilePath = FullNameTrack.FirstOrDefault(path => System.IO.Path.GetFileName(path) == selectedFileName);

                if (!string.IsNullOrEmpty(selectedFilePath))
                {
                    media.Source = new Uri(selectedFilePath);
                    media.Play();
                    playlist.SelectedItem = historywin.FilePath;
                }
            }
        }

        private void musicSlid_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (ignoreMusicSlidChange == false)
            {
                media.Position = new TimeSpan(Convert.ToInt64(musicSlid.Value));
            }
        }

        private void media_MediaOpened(object sender, RoutedEventArgs e)
        {
            ignoreMusicSlidChange = true;
            musicSlid.Maximum = media.NaturalDuration.TimeSpan.Ticks;
            ignoreMusicSlidChange = false;
            timer.Start();

        }
        private void playlist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(playlist.SelectedItem != null)
            {
                PlayButton.Content = "Играть";
                PlayPause = true;
                string selectedFileName = System.IO.Path.GetFileName(FullNameTrack[playlist.SelectedIndex]);
                TrackIndex = playlist.SelectedIndex;               
                media.Source = new Uri(FullNameTrack[playlist.SelectedIndex]);
                media.Play();
                AddInHistory(new FileInfo(selectedFileName));
            }
        }

        private void VolumeSlid_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (media != null)
            {
                media.Volume = VolumeSlid.Value;
            }
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            if (PlayPause == true)
            {
                media.Pause();
                PlayButton.Content = "Пауза";
                PlayPause = false;
            }
            else 
            {
                media.Play();
                PlayButton.Content = "Играть";
                PlayPause = true;
            }
        }

        private void ForwardButton_Click(object sender, RoutedEventArgs e)
        {
            PlayButton.Content = "Играть";
            PlayPause = true;
            TrackIndex++;

            if (TrackIndex >= FullNameTrack.Count)
            {
                TrackIndex = 0;
            }

            string selectedFilePath = FullNameTrack[TrackIndex];
            media.Source = new Uri(selectedFilePath);
            media.Play();
            AddInHistory(new FileInfo(System.IO.Path.GetFileName(selectedFilePath)));
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            PlayButton.Content = "Играть";
            PlayPause = true;
            TrackIndex--;

            if (TrackIndex < 0)
            {
                TrackIndex = FullNameTrack.Count - 1;
            }

            string selectedFilePath = FullNameTrack[TrackIndex];
            media.Source = new Uri(selectedFilePath);
            media.Play();
            AddInHistory(new FileInfo(System.IO.Path.GetFileName(selectedFilePath)));
        }

        private void media_MediaEnded(object sender, RoutedEventArgs e)
        {
            PlayButton.Content = "Играть";
            PlayPause = true;
            if (Repeat == true)
            {
                media.Position = TimeSpan.Zero;
                media.Play();
            }
            else
            {
                TrackIndex++;
                if (TrackIndex >= FullNameTrack.Count)
                {
                    TrackIndex = 0;
                }

                string selectedFilePath = FullNameTrack[TrackIndex];
                media.Source = new Uri(selectedFilePath);
                media.Play();
                AddInHistory(new FileInfo(System.IO.Path.GetFileName(selectedFilePath)));
            }

            musicSlid.Value = 0;

        }
        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            if (Repeat == false)
            {
                RepeatButton.Content = "Повтор вкл.";
                Repeat = true;

            }
            else 
            {
                RepeatButton.Content = "Повтор";
                Repeat = false;                                

            }
        }

        private void basa_Closed(object sender, EventArgs e)
        {
            media.Close();
            Application.Current.Shutdown();

        }

        private void RandomButton_Click(object sender, RoutedEventArgs e)
        {
            if (isRandom == false)
            {
                SaveOriginalOrder();
                RandomTracks();
                RandomButton.Content = "Работает";
            }
            else
            {
                FullNameTrack = new List<string>(originalOrder);
                RandomButton.Content = "Случайно";
            }

            playlist.Items.Clear();

            foreach (string file in FullNameTrack)
            {
                string fileName = System.IO.Path.GetFileName(file);
                playlist.Items.Add(fileName);
            }

            if (playlist.Items.Count > 0)
            {
                string selectedFilePath = FullNameTrack[0];
                media.Source = new Uri(selectedFilePath);
                media.Play();
                AddInHistory(new FileInfo(System.IO.Path.GetFileName(selectedFilePath)));
            }

            isRandom = !isRandom;

        }
        private void SaveOriginalOrder()
        {
            originalOrder = new List<string>(FullNameTrack);
        }
        private void RandomTracks()
        {
            Random random = new Random();
            int n = FullNameTrack.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                string value = FullNameTrack[k];
                FullNameTrack[k] = FullNameTrack[n];
                FullNameTrack[n] = value;
            }
        }

    }
}
