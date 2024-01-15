using System.Windows;
using System.Windows.Controls;

namespace Vagtcentral
{
    /// <summary>
    /// Interaction logic for IndstillingerWindow.xaml
    /// </summary>
    public partial class IndstillingerWindow : Window
    {

        public MainWindow MainWindowAccess = new MainWindow();

        public IndstillingerWindow()
        {
            InitializeComponent();
            GruppeListView1.ItemsSource = null;
            GruppeListView1.ItemsSource = MainWindowAccess.GruppeList1;
            GruppeListView2.ItemsSource = MainWindowAccess.GruppeList2;
            GruppeListView3.ItemsSource = MainWindowAccess.GruppeList3;
            GruppeListView4.ItemsSource = MainWindowAccess.GruppeList4;
            GruppeListView5.ItemsSource = MainWindowAccess.GruppeList5;
            GruppeListView6.ItemsSource = MainWindowAccess.GruppeList6;
            GruppeListView7.ItemsSource = MainWindowAccess.GruppeList7;
            GruppeListView8.ItemsSource = MainWindowAccess.GruppeList8;
            GruppeListView9.ItemsSource = MainWindowAccess.GruppeList9;
            GruppeListView10.ItemsSource = MainWindowAccess.GruppeList10;
            GruppeListView11.ItemsSource = MainWindowAccess.GruppeList11;
            GruppeListView12.ItemsSource = MainWindowAccess.GruppeList12;
            UserNameInput.Text = MainWindowAccess.Username;
            passwordInput.Password = MainWindowAccess.Password;
        }

        public void AddNumberButton_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxItem typeItem = (ComboBoxItem)AddToGrupMenu.SelectedItem;
            string AddNumberSwitch = typeItem.Content.ToString();

            switch (AddNumberSwitch)
            {
                case "Gruppe 1":
                    {
                        MainWindowAccess.GruppeList1.Add(AddPhoneNumber.Text);
                        GruppeListView1.ItemsSource = null;
                        GruppeListView1.ItemsSource = MainWindowAccess.GruppeList1;
                        AddPhoneNumber.Text = "";
                        MainWindowAccess.SaveSettings();
                        break;
                    }

                case "Gruppe 2":
                    {
                        MainWindowAccess.GruppeList2.Add(AddPhoneNumber.Text);
                        GruppeListView2.ItemsSource = null;
                        GruppeListView2.ItemsSource = MainWindowAccess.GruppeList2;
                        AddPhoneNumber.Text = "";
                        MainWindowAccess.SaveSettings();
                        break;
                    }

                case "Gruppe 3":
                    {
                        MainWindowAccess.GruppeList3.Add(AddPhoneNumber.Text);
                        GruppeListView3.ItemsSource = null;
                        GruppeListView3.ItemsSource = MainWindowAccess.GruppeList3;
                        AddPhoneNumber.Text = "";
                        MainWindowAccess.SaveSettings();
                        break;
                    }

                case "Gruppe 4":
                    {
                        MainWindowAccess.GruppeList4.Add(AddPhoneNumber.Text);
                        GruppeListView4.ItemsSource = null;
                        GruppeListView4.ItemsSource = MainWindowAccess.GruppeList4;
                        AddPhoneNumber.Text = "";
                        MainWindowAccess.SaveSettings();
                        break;
                    }

                case "Gruppe 5":
                    {
                        MainWindowAccess.GruppeList5.Add(AddPhoneNumber.Text);
                        GruppeListView5.ItemsSource = null;
                        GruppeListView5.ItemsSource = MainWindowAccess.GruppeList5;
                        AddPhoneNumber.Text = "";
                        MainWindowAccess.SaveSettings();
                        break;
                    }

                case "Gruppe 6":
                    {
                        MainWindowAccess.GruppeList6.Add(AddPhoneNumber.Text);
                        GruppeListView6.ItemsSource = null;
                        GruppeListView6.ItemsSource = MainWindowAccess.GruppeList6;
                        AddPhoneNumber.Text = "";
                        MainWindowAccess.SaveSettings();
                        break;
                    }

                case "Gruppe 7":
                    {
                        MainWindowAccess.GruppeList7.Add(AddPhoneNumber.Text);
                        GruppeListView7.ItemsSource = null;
                        GruppeListView7.ItemsSource = MainWindowAccess.GruppeList7;
                        AddPhoneNumber.Text = "";
                        MainWindowAccess.SaveSettings();
                        break;
                    }

                case "Gruppe 8":
                    {
                        MainWindowAccess.GruppeList8.Add(AddPhoneNumber.Text);
                        GruppeListView8.ItemsSource = null;
                        GruppeListView8.ItemsSource = MainWindowAccess.GruppeList8;
                        AddPhoneNumber.Text = "";
                        MainWindowAccess.SaveSettings();
                        break;
                    }

                case "Gruppe 9":
                    {
                        MainWindowAccess.GruppeList9.Add(AddPhoneNumber.Text);
                        GruppeListView9.ItemsSource = null;
                        GruppeListView9.ItemsSource = MainWindowAccess.GruppeList9;
                        AddPhoneNumber.Text = "";
                        MainWindowAccess.SaveSettings();
                        break;
                    }

                case "Gruppe 10":
                    {
                        MainWindowAccess.GruppeList10.Add(AddPhoneNumber.Text);
                        GruppeListView10.ItemsSource = null;
                        GruppeListView10.ItemsSource = MainWindowAccess.GruppeList10;
                        AddPhoneNumber.Text = "";
                        MainWindowAccess.SaveSettings();
                        break;
                    }

                case "Gruppe 11":
                    {
                        MainWindowAccess.GruppeList11.Add(AddPhoneNumber.Text);
                        GruppeListView11.ItemsSource = null;
                        GruppeListView11.ItemsSource = MainWindowAccess.GruppeList11;
                        AddPhoneNumber.Text = "";
                        MainWindowAccess.SaveSettings();
                        break;
                    }

                case "Gruppe 12":
                    {
                        MainWindowAccess.GruppeList12.Add(AddPhoneNumber.Text);
                        GruppeListView12.ItemsSource = null;
                        GruppeListView12.ItemsSource = MainWindowAccess.GruppeList12;
                        AddPhoneNumber.Text = "";
                        MainWindowAccess.SaveSettings();
                        break;
                    }

                default:
                    MessageBox.Show("Der er sket en uventet fejl, forsøg venligst igen!!");
                    break;
            }
        }

        private void GemIndstillingerButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindowAccess.Username = UserNameInput.Text;
            MainWindowAccess.Password = passwordInput.Password;
            MainWindowAccess.SaveSettings();
            MessageBox.Show("Dine indstillinger blev gemt!!");
        }

        private void DeleteNumberButton_Click(object sender, RoutedEventArgs e)
        {
            if (GruppeListView1.SelectedIndex > -1)
            {

                MainWindowAccess.GruppeList1.RemoveAt(GruppeListView1.SelectedIndex);
                GruppeListView1.ItemsSource = null;
                GruppeListView1.ItemsSource = MainWindowAccess.GruppeList1;
                MainWindowAccess.SaveSettings();
            }

            if (GruppeListView2.SelectedIndex > -1)
            {
                MainWindowAccess.GruppeList2.RemoveAt(GruppeListView2.SelectedIndex);
                GruppeListView2.ItemsSource = null;
                GruppeListView2.ItemsSource = MainWindowAccess.GruppeList2;
                MainWindowAccess.SaveSettings();
            }

            if (GruppeListView3.SelectedIndex > -1)
            {
                MainWindowAccess.GruppeList3.RemoveAt(GruppeListView3.SelectedIndex);
                GruppeListView3.ItemsSource = null;
                GruppeListView3.ItemsSource = MainWindowAccess.GruppeList3;
                MainWindowAccess.SaveSettings();
            }

            if (GruppeListView4.SelectedIndex > -1)
            {
                MainWindowAccess.GruppeList4.RemoveAt(GruppeListView4.SelectedIndex);
                GruppeListView4.ItemsSource = null;
                GruppeListView4.ItemsSource = MainWindowAccess.GruppeList4;
                MainWindowAccess.SaveSettings();
            }

            if (GruppeListView5.SelectedIndex > -1)
            {
                MainWindowAccess.GruppeList5.RemoveAt(GruppeListView5.SelectedIndex);
                GruppeListView5.ItemsSource = null;
                GruppeListView5.ItemsSource = MainWindowAccess.GruppeList5;
                MainWindowAccess.SaveSettings();
            }

            if (GruppeListView6.SelectedIndex > -1)
            {
                MainWindowAccess.GruppeList6.RemoveAt(GruppeListView6.SelectedIndex);
                GruppeListView6.ItemsSource = null;
                GruppeListView6.ItemsSource = MainWindowAccess.GruppeList6;
                MainWindowAccess.SaveSettings();
            }

            if (GruppeListView7.SelectedIndex > -1)
            {
                MainWindowAccess.GruppeList7.RemoveAt(GruppeListView7.SelectedIndex);
                GruppeListView7.ItemsSource = null;
                GruppeListView7.ItemsSource = MainWindowAccess.GruppeList7;
                MainWindowAccess.SaveSettings();
            }

            if (GruppeListView8.SelectedIndex > -1)
            {
                MainWindowAccess.GruppeList8.RemoveAt(GruppeListView8.SelectedIndex);
                GruppeListView8.ItemsSource = null;
                GruppeListView8.ItemsSource = MainWindowAccess.GruppeList8;
                MainWindowAccess.SaveSettings();
            }

            if (GruppeListView9.SelectedIndex > -1)
            {
                MainWindowAccess.GruppeList9.RemoveAt(GruppeListView9.SelectedIndex);
                GruppeListView9.ItemsSource = null;
                GruppeListView9.ItemsSource = MainWindowAccess.GruppeList9;
                MainWindowAccess.SaveSettings();
            }

            if (GruppeListView10.SelectedIndex > -1)
            {
                MainWindowAccess.GruppeList10.RemoveAt(GruppeListView10.SelectedIndex);
                GruppeListView10.ItemsSource = null;
                GruppeListView10.ItemsSource = MainWindowAccess.GruppeList10;
                MainWindowAccess.SaveSettings();
            }

            if (GruppeListView11.SelectedIndex > -1)
            {
                MainWindowAccess.GruppeList11.RemoveAt(GruppeListView11.SelectedIndex);
                GruppeListView11.ItemsSource = null;
                GruppeListView11.ItemsSource = MainWindowAccess.GruppeList11;
                MainWindowAccess.SaveSettings();
            }

            if (GruppeListView12.SelectedIndex > -1)
            {
                MainWindowAccess.GruppeList12.RemoveAt(GruppeListView12.SelectedIndex);
                GruppeListView12.ItemsSource = null;
                GruppeListView12.ItemsSource = MainWindowAccess.GruppeList12;
                MainWindowAccess.SaveSettings();
            }
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.suresms.com/dk/");
            }
            catch { }
        }

        private void UpdateSettingsButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindowAccess.LoadSettings();
        }
    }
}
