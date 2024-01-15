using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Xml;
using System.Net;
using System;

namespace Vagtcentral
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Patch til fil lokationer.
        public string FilePatch = @"c:\Vagtcentral Save\Settings.xaml";
        public string DirectoryPatch = @"c:\Vagtcentral Save";

        //Lister med telefonnumre for de enkelte grupper.
        public List<string> GruppeList1 = new List<string>();
        public List<string> GruppeList2 = new List<string>();
        public List<string> GruppeList3 = new List<string>();
        public List<string> GruppeList4 = new List<string>();
        public List<string> GruppeList5 = new List<string>();
        public List<string> GruppeList6 = new List<string>();
        public List<string> GruppeList7 = new List<string>();
        public List<string> GruppeList8 = new List<string>();
        public List<string> GruppeList9 = new List<string>();
        public List<string> GruppeList10 = new List<string>();
        public List<string> GruppeList11 = new List<string>();
        public List<string> GruppeList12 = new List<string>();

        //Strings for brugernavn og password til sms senderen.
        public string Username;
        public string Password;

        public MainWindow()
        {
            InitializeComponent();

            if (File.Exists(FilePatch))
            {
                LoadSettings();
            }

            else if (Directory.Exists(DirectoryPatch) == false)
            {
                Directory.CreateDirectory(@"c:\Vagtcentral Save");
                MessageBox.Show("Det er første gang du bruger programmet, og der er derfor automatisk blevet oprettet en mappe til dine gemte indstillinger, som vil være at finde under c:\\Vagtcentral Save");
            }
        }

        //Metode der kalder vinduet indstillinger.
        private void Indstillinger_Click(object sender, RoutedEventArgs e)
        {
            IndstillingerWindow win2 = new IndstillingerWindow();
            win2.Show();
        }

        //Metoder for gruppe knapperne.
        private void GruppeButton1_Click(object sender, RoutedEventArgs e)
        {
            if (GruppeButton1.Background == Brushes.Red)
            {
                GruppeButton1.Background = Brushes.Green;
            }
            else
            {
                GruppeButton1.Background = Brushes.Red;
            }
        }

        private void GruppeButton2_Click(object sender, RoutedEventArgs e)
        {

            if (GruppeButton2.Background == Brushes.Red)
            {
                GruppeButton2.Background = Brushes.Green;
            }

            else
            {
                GruppeButton2.Background = Brushes.Red;
            }
        }

        private void GruppeButton3_Click(object sender, RoutedEventArgs e)
        {

            if (GruppeButton3.Background == Brushes.Red)
            {
                GruppeButton3.Background = Brushes.Green;
            }

            else
            {
                GruppeButton3.Background = Brushes.Red;
            }
        }

        private void GruppeButton4_Click(object sender, RoutedEventArgs e)
        {
            if (GruppeButton4.Background == Brushes.Red)
            {
                GruppeButton4.Background = Brushes.Green;
            }

            else
            {
                GruppeButton4.Background = Brushes.Red;
            }
        }

        private void GruppeButton5_Click(object sender, RoutedEventArgs e)
        {
            if (GruppeButton5.Background == Brushes.Red)
            {
                GruppeButton5.Background = Brushes.Green;
            }

            else
            {
                GruppeButton5.Background = Brushes.Red;
            }
        }

        private void GruppeButton6_Click(object sender, RoutedEventArgs e)
        {
            if (GruppeButton6.Background == Brushes.Red)
            {
                GruppeButton6.Background = Brushes.Green;
            }

            else
            {
                GruppeButton6.Background = Brushes.Red;
            }
        }

        private void GruppeButton7_Click(object sender, RoutedEventArgs e)
        {
            if (GruppeButton7.Background == Brushes.Red)
            {
                GruppeButton7.Background = Brushes.Green;
            }

            else
            {
                GruppeButton7.Background = Brushes.Red;
            }
        }

        private void GruppeButton8_Click(object sender, RoutedEventArgs e)
        {
            if (GruppeButton8.Background == Brushes.Red)
            {
                GruppeButton8.Background = Brushes.Green;
            }

            else
            {
                GruppeButton8.Background = Brushes.Red;
            }
        }

        private void GruppeButton9_Click(object sender, RoutedEventArgs e)
        {
            if (GruppeButton9.Background == Brushes.Red)
            {
                GruppeButton9.Background = Brushes.Green;
            }

            else
            {
                GruppeButton9.Background = Brushes.Red;
            }
        }

        private void GruppeButton10_Click(object sender, RoutedEventArgs e)
        {
            if (GruppeButton10.Background == Brushes.Red)
            {
                GruppeButton10.Background = Brushes.Green;
            }

            else
            {
                GruppeButton10.Background = Brushes.Red;
            }
        }

        private void GruppeButton11_Click(object sender, RoutedEventArgs e)
        {
            if (GruppeButton11.Background == Brushes.Red)
            {
                GruppeButton11.Background = Brushes.Green;
            }

            else
            {
                GruppeButton11.Background = Brushes.Red;
            }
        }

        private void GruppeButton12_Click(object sender, RoutedEventArgs e)
        {
            if (GruppeButton12.Background == Brushes.Red)
            {
                GruppeButton12.Background = Brushes.Green;
            }

            else
            {
                GruppeButton12.Background = Brushes.Red;
            }
        }

        //Metode til lukning af programmet fra menuen.
        private void MenuExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        //Metode til at gemme indstillingerne i en xml fil.
        public void SaveSettings()
        {
            //Indlæser og starter XML writeren.
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            XmlWriter writer = XmlWriter.Create(FilePatch, settings);       //Dette åbner writer og skriver filen.
            writer.WriteStartDocument();                                    //Starter dokumentet.
            writer.WriteComment("Dette er en automatisk genereret fil, som indeholder gemte indstillinger for Vagtcentral");    //Opretter kommentar i filen.
            writer.WriteStartElement("NumreLister");                        //Opretter overkategorien.

            //Gruppe 1 save.
            writer.WriteStartElement("NummerList1");                        //Opretter under kategori.

            foreach (string nummer1 in GruppeList1)                         //Tjekker indhold og kører for hvert nummer i listen.
            {
                writer.WriteElementString("Nummer", nummer1);               //Opretter en string for hvert nummer i listen.
            }

            writer.WriteEndElement();                                       //Lukker under kategorien for den gældende liste.

            //Gruppe 2 save.
            writer.WriteStartElement("NummerList2");

            foreach (string nummer2 in GruppeList2)
            {
                writer.WriteElementString("Nummer", nummer2);
            }

            writer.WriteEndElement();

            //Gruppe 3 save.
            writer.WriteStartElement("NummerList3");

            foreach (string nummer3 in GruppeList3)
            {
                writer.WriteElementString("Nummer", nummer3);
            }

            writer.WriteEndElement();

            //Gruppe 4 save.
            writer.WriteStartElement("NummerList4");

            foreach (string nummer4 in GruppeList4)
            {
                writer.WriteElementString("Nummer", nummer4);
            }

            writer.WriteEndElement();

            //Gruppe 5 save.
            writer.WriteStartElement("NummerList5");

            foreach (string nummer5 in GruppeList5)
            {
                writer.WriteElementString("Nummer", nummer5);
            }

            writer.WriteEndElement();

            //Gruppe 6 save.
            writer.WriteStartElement("NummerList6");

            foreach (string nummer6 in GruppeList6)
            {
                writer.WriteElementString("Nummer", nummer6);
            }

            writer.WriteEndElement();

            //Gruppe 7 save.
            writer.WriteStartElement("NummerList7");

            foreach (string nummer7 in GruppeList7)
            {
                writer.WriteElementString("Nummer", nummer7);
            }

            writer.WriteEndElement();

            //Gruppe 8 save.
            writer.WriteStartElement("NummerList8");

            foreach (string nummer8 in GruppeList8)
            {
                writer.WriteElementString("Nummer", nummer8);
            }

            writer.WriteEndElement();

            //Gruppe 9 save.
            writer.WriteStartElement("NummerList9");

            foreach (string nummer9 in GruppeList9)
            {
                writer.WriteElementString("Nummer", nummer9);
            }

            writer.WriteEndElement();

            //Gruppe 10 save.
            writer.WriteStartElement("NummerList10");

            foreach (string nummer10 in GruppeList10)
            {
                writer.WriteElementString("Nummer", nummer10);
            }

            writer.WriteEndElement();

            //Gruppe 11 save.
            writer.WriteStartElement("NummerList11");

            foreach (string nummer11 in GruppeList11)
            {
                writer.WriteElementString("Nummer", nummer11);
            }

            writer.WriteEndElement();

            //Gruppe 12 save.
            writer.WriteStartElement("NummerList12");

            foreach (string nummer12 in GruppeList12)
            {
                writer.WriteElementString("Nummer", nummer12);
            }

            writer.WriteEndElement();

            //Save Username and password.
            writer.WriteStartElement("Username");
            writer.WriteElementString("Username", Username);
            writer.WriteEndElement();

            writer.WriteStartElement("Password");
            writer.WriteElementString("Password", Password);
            writer.WriteEndElement();

            //Lukker dokumentet og writeren.
            writer.WriteEndElement();
            writer.WriteEndDocument();

            writer.Flush();
            writer.Close();
        }

        //Metode til at indlæse indstillinger fra fil.
        public void LoadSettings()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(FilePatch);
                XmlElement root = doc.DocumentElement;

                if (root.SelectSingleNode("NummerList1") != null)
                {
                    XmlNode NummerNode1 = root.SelectSingleNode("NummerList1");
                    foreach (XmlNode Node1 in NummerNode1.ChildNodes)
                        GruppeList1.Add(Node1.InnerText);
                }

                if (root.SelectSingleNode("NummerList2") != null)
                {
                    XmlNode NummerNode2 = root.SelectSingleNode("NummerList2");
                    foreach (XmlNode Node2 in NummerNode2.ChildNodes)
                    {
                        GruppeList2.Add(Node2.InnerText);
                    }

                }

                if (root.SelectSingleNode("NummerList3") != null)
                {
                    XmlNode NummerNode3 = root.SelectSingleNode("NummerList3");
                    foreach (XmlNode Node3 in NummerNode3.ChildNodes)
                    {
                        GruppeList3.Add(Node3.InnerText);
                    }
                }

                if (root.SelectSingleNode("NummerList4") != null)
                {
                    XmlNode NummerNode4 = root.SelectSingleNode("NummerList4");

                    foreach (XmlNode Node4 in NummerNode4.ChildNodes)
                    {
                        GruppeList4.Add(Node4.InnerText);
                    }
                }

                if (root.SelectSingleNode("NummerList5") != null)
                {
                    XmlNode NummerNode5 = root.SelectSingleNode("NummerList5");

                    foreach (XmlNode Node5 in NummerNode5.ChildNodes)
                    {
                        GruppeList5.Add(Node5.InnerText);
                    }
                }

                if (root.SelectSingleNode("NummerList6") != null)
                {
                    XmlNode NummerNode6 = root.SelectSingleNode("NummerList6");

                    foreach (XmlNode Node6 in NummerNode6.ChildNodes)
                    {
                        GruppeList6.Add(Node6.InnerText);
                    }
                }

                if (root.SelectSingleNode("NummerList7") != null)
                {
                    XmlNode NummerNode7 = root.SelectSingleNode("NummerList7");

                    foreach (XmlNode Node7 in NummerNode7.ChildNodes)
                    {
                        GruppeList7.Add(Node7.InnerText);
                    }
                }

                if (root.SelectSingleNode("NummerList8") != null)
                {
                    XmlNode NummerNode8 = root.SelectSingleNode("NummerList8");

                    foreach (XmlNode Node8 in NummerNode8.ChildNodes)
                    {
                        GruppeList8.Add(Node8.InnerText);
                    }
                }

                if (root.SelectSingleNode("NummerList9") != null)
                {
                    XmlNode NummerNode9 = root.SelectSingleNode("NummerList9");

                    foreach (XmlNode Node9 in NummerNode9.ChildNodes)
                    {
                        GruppeList9.Add(Node9.InnerText);
                    }
                }

                if (root.SelectSingleNode("NummerList10") != null)
                {
                    XmlNode NummerNode10 = root.SelectSingleNode("NummerList10");

                    foreach (XmlNode Node10 in NummerNode10.ChildNodes)
                    {
                        GruppeList10.Add(Node10.InnerText);
                    }
                }

                if (root.SelectSingleNode("NummerList11") != null)
                {
                    XmlNode NummerNode11 = root.SelectSingleNode("NummerList11");

                    foreach (XmlNode Node11 in NummerNode11.ChildNodes)
                    {
                        GruppeList11.Add(Node11.InnerText);
                    }
                }

                if (root.SelectSingleNode("NummerList12") != null)
                {
                    XmlNode NummerNode12 = root.SelectSingleNode("NummerList12");

                    foreach (XmlNode Node12 in NummerNode12.ChildNodes)
                    {
                        GruppeList12.Add(Node12.InnerText);
                    }
                }

                if (root.SelectSingleNode("Username") != null)
                {
                    XmlNode UserNode = root.SelectSingleNode("Username");
                    Username = UserNode.InnerText;
                }

                if (root.SelectSingleNode("Password") != null)
                {
                    XmlNode PasswordNode = root.SelectSingleNode("Password");
                    Password = PasswordNode.InnerText;
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Kunne ikke indlæse dine gemte indstillinger, prøv at lukke programmet og kør det igen");
            }


        }

        //SMS sender fra Suresms.com
        protected void SendMessage(string NumberFromGroup, string message)
        {
            string SendtToText = "Meddelelsen sendt til: " + NumberFromGroup + "\n";
            string username = Username;
            string password = Password;
            string tophonenumberwithcountrycode = "+45" + NumberFromGroup;
            string fromMax11Char = "Vagtcentral";
            string theMessage = message;

            string pathtouse = "https://www.suresms.com/Script/GlobalSendSMS.aspx" + "?login=" + username + "&password=" + password +
            "&to=" + tophonenumberwithcountrycode + "&from=" + fromMax11Char + "&Text=" + WebUtility.UrlEncode(theMessage);

            int Count = 0;

            LogViewer(SendtToText);

            //While loop sørger for nyt forsøg ved fejl af afsendelsen.
            while (Count < 5)
            {
                try
                {
                    /* Call the Path */
                    WebRequest wrGETURL;
                    wrGETURL = WebRequest.Create(pathtouse);
                    Stream objStream;
                    objStream = wrGETURL.GetResponse().GetResponseStream();
                    objStream.Close();
                    wrGETURL = null;
                    SendtToText = null;
                    Count = Count + 6;
                }

                catch (Exception ex)
                {
                    Count = Count + 1;
                    MessageBox.Show(ex.Message);
                    LogViewer(ex.Message);
                    System.Threading.Thread.Sleep(5000);
                }
            }
        }

        //Metode for afsendelse af udkald.
        private void SendUdkaldButton_Click(object sender, RoutedEventArgs e)
        {
            LoadSettings();

            //Send til gruppe 1.
            if (GruppeButton1.Background == Brushes.Green)
            {
                SendUdkaldButton.Background = Brushes.Red;
                string StartText = "Sender melding til gruppe 1: \n";
                LogViewer(StartText);
                int SMSCount = 1;

                foreach (string number1 in GruppeList1)
                {
                    string message = SMSCount + ". " + "Gruppe 1: " + MeldingTextBox.Text;
                    SendMessage(number1, message);
                    System.Threading.Thread.Sleep(500);
                    SMSCount = SMSCount + 1;
                }

                string EndText = "Meldingen blev sendt til alle modtagere i gruppe 1 med success. :)\n\n";
                LogViewer(EndText);
                SendUdkaldButton.Background = Brushes.Green;
                GruppeButton1.Background = Brushes.Red;
                MeldingTextBox.Text = "";
            }

            //Send til gruppe 2.
            if (GruppeButton2.Background == Brushes.Green)
            {
                SendUdkaldButton.Background = Brushes.Red;
                string StartText = "Sender melding til gruppe 2: \n";
                LogViewer(StartText);
                int SMSCount = 1;

                foreach (string number2 in GruppeList2)
                {
                    string message = SMSCount + ". " + "Gruppe 2: " + MeldingTextBox.Text;
                    SendMessage(number2, message);
                    System.Threading.Thread.Sleep(500);
                    SMSCount = SMSCount + 1;
                }

                string EndText = "Meldingen blev sendt til alle modtagere i gruppe 2 med success. :)\n\n";
                LogViewer(EndText);
                SendUdkaldButton.Background = Brushes.Green;
                GruppeButton2.Background = Brushes.Red;
                MeldingTextBox.Text = "";
            }

            //Send til gruppe 3.
            if (GruppeButton3.Background == Brushes.Green)
            {
                SendUdkaldButton.Background = Brushes.Red;
                string StartText = "Sender melding til gruppe 3: \n";
                LogViewer(StartText);
                int SMSCount = 1;

                foreach (string number3 in GruppeList3)
                {
                    string message = SMSCount + ". " + "Gruppe 3: " + MeldingTextBox.Text;
                    SendMessage(number3, message);
                    System.Threading.Thread.Sleep(500);
                    SMSCount = SMSCount + 1;
                }

                string EndText = "Meldingen blev sendt til alle modtagere i gruppe 3 med success. :)\n\n";
                LogViewer(EndText);
                SendUdkaldButton.Background = Brushes.Green;
                GruppeButton3.Background = Brushes.Red;
                MeldingTextBox.Text = "";
            }

            //Send til gruppe 4.
            if (GruppeButton4.Background == Brushes.Green)
            {
                SendUdkaldButton.Background = Brushes.Red;
                string StartText = "Sender melding til gruppe 4: \n";
                LogViewer(StartText);
                int SMSCount = 1;

                foreach (string number4 in GruppeList4)
                {
                    string Message = SMSCount + ". " + "Gruppe 4: " + MeldingTextBox.Text;
                    SendMessage(number4, Message);
                    System.Threading.Thread.Sleep(500);
                    SMSCount = SMSCount + 1;
                }

                string EndText = "Meldingen blev sendt til alle modtagere i gruppe 4 med success. :)\n\n";
                LogViewer(EndText);
                SendUdkaldButton.Background = Brushes.Green;
                GruppeButton4.Background = Brushes.Red;
                MeldingTextBox.Text = "";
            }

            //Send til gruppe 5.
            if (GruppeButton5.Background == Brushes.Green)
            {
                SendUdkaldButton.Background = Brushes.Red;
                string StartText = "Sender melding til gruppe 5: \n";
                LogViewer(StartText);
                int SMSCount = 1;

                foreach (string number5 in GruppeList5)
                {
                    string Message = SMSCount + ". " + "Gruppe 5: " + MeldingTextBox.Text;
                    SendMessage(number5, Message);
                    System.Threading.Thread.Sleep(500);
                    SMSCount = SMSCount + 1;
                }

                string EndText = "Meldingen blev sendt til alle modtagere i gruppe 5 med success. :)\n\n";
                LogViewer(EndText);
                SendUdkaldButton.Background = Brushes.Green;
                GruppeButton5.Background = Brushes.Red;
                MeldingTextBox.Text = "";
            }

            //Send til gruppe 6.
            if (GruppeButton6.Background == Brushes.Green)
            {
                SendUdkaldButton.Background = Brushes.Red;
                string StartText = "Sender melding til gruppe 6: \n";
                LogViewer(StartText);
                int SMSCount = 1;

                foreach (string number6 in GruppeList6)
                {
                    string Message = SMSCount + ". " + "Gruppe 6: " + MeldingTextBox.Text;
                    SendMessage(number6, Message);
                    System.Threading.Thread.Sleep(500);
                    SMSCount = SMSCount + 1;
                }

                string EndText = "Meldingen blev sendt til alle modtagere i gruppe 6 med success. :)\n\n";
                LogViewer(EndText);
                SendUdkaldButton.Background = Brushes.Green;
                GruppeButton6.Background = Brushes.Red;
                MeldingTextBox.Text = "";
            }

            //Send til gruppe 7.
            if (GruppeButton7.Background == Brushes.Green)
            {
                SendUdkaldButton.Background = Brushes.Red;
                string StartText = "Sender melding til gruppe 7: \n";
                LogViewer(StartText);
                int SMSCount = 1;

                foreach (string number7 in GruppeList7)
                {
                    string Message = SMSCount + ". " + "Gruppe 7: " + MeldingTextBox.Text;
                    SendMessage(number7, Message);
                    System.Threading.Thread.Sleep(500);
                    SMSCount = SMSCount + 1;
                }

                string EndText = "Meldingen blev sendt til alle modtagre i gruppe 7 med success. :)\n\n";
                LogViewer(EndText);
                SendUdkaldButton.Background = Brushes.Green;
                GruppeButton7.Background = Brushes.Red;
                MeldingTextBox.Text = "";
            }

            //Send til gruppe 8.
            if (GruppeButton8.Background == Brushes.Green)
            {
                SendUdkaldButton.Background = Brushes.Red;
                string StartText = "Sender melding til gruppe 8: \n";
                LogViewer(StartText);
                int SMSCount = 1;

                foreach (string number8 in GruppeList8)
                {
                    string message = SMSCount + ". " + "Gruppe 8: " + MeldingTextBox.Text;
                    SendMessage(number8, message);
                    System.Threading.Thread.Sleep(500);
                    SMSCount = SMSCount + 1;
                }

                string EndText = "Meldingen blev sendt til alle modtagere i gruppe 8 med success. :)\n\n";
                LogViewer(EndText);
                SendUdkaldButton.Background = Brushes.Green;
                GruppeButton8.Background = Brushes.Red;
                MeldingTextBox.Text = "";
            }

            //Send til gruppe 9.
            if (GruppeButton9.Background == Brushes.Green)
            {
                SendUdkaldButton.Background = Brushes.Red;
                string StartText = "Sender melding til gruppe 9: \n";
                LogViewer(StartText);
                int SMSCount = 1;

                foreach (string number9 in GruppeList9)
                {
                    string message = SMSCount + ". " + "Gruppe 9: " + MeldingTextBox.Text;
                    SendMessage(number9, message);
                    System.Threading.Thread.Sleep(500);
                    SMSCount = SMSCount + 1;
                }

                string EndText = "Meldingen blev sendt til alle modtagere i gruppe 9 med success. :)\n\n";
                LogViewer(EndText);
                SendUdkaldButton.Background = Brushes.Green;
                GruppeButton9.Background = Brushes.Red;
                MeldingTextBox.Text = "";
            }

            //Send til gruppe 10.
            if (GruppeButton10.Background == Brushes.Green)
            {
                SendUdkaldButton.Background = Brushes.Red;
                string StartText = "Sender melding til gruppe 10: \n";
                LogViewer(StartText);
                int SMSCount = 1;

                foreach (string number10 in GruppeList10)
                {
                    string message = SMSCount + ". " + "Gruppe 10: " + MeldingTextBox.Text;
                    SendMessage(number10, message);
                    System.Threading.Thread.Sleep(500);
                    SMSCount = SMSCount + 1;
                }

                string EndText = "Meldingen blev sendt til alle modtagere i gruppe 10 med success. :)\n\n";
                LogViewer(EndText);
                SendUdkaldButton.Background = Brushes.Green;
                GruppeButton10.Background = Brushes.Red;
                MeldingTextBox.Text = "";
            }

            //Send til gruppe 11.
            if (GruppeButton11.Background == Brushes.Green)
            {
                SendUdkaldButton.Background = Brushes.Red;
                string StartText = "Sender melding til gruppe 11: \n";
                LogViewer(StartText);
                int SMSCount = 1;

                foreach (string number11 in GruppeList11)
                {
                    string message = SMSCount + ". " + "Gruppe 11: " + MeldingTextBox.Text;
                    SendMessage(number11, message);
                    System.Threading.Thread.Sleep(500);
                    SMSCount = SMSCount + 1;
                }

                string EndText = "Meldingen blev sendt til alle modtagere i gruppe 11 med success. :)\n\n";
                LogViewer(EndText);
                SendUdkaldButton.Background = Brushes.Green;
                GruppeButton11.Background = Brushes.Red;
                MeldingTextBox.Text = "";
            }

            //Send til gruppe 12.
            if (GruppeButton12.Background == Brushes.Green)
            {
                SendUdkaldButton.Background = Brushes.Red;
                string StartText = "Sender melding til gruppe 12: \n";
                LogViewer(StartText);
                int SMSCount = 1;

                foreach (string number12 in GruppeList12)
                {
                    string message = SMSCount + ". " + "Gruppe 12: " + MeldingTextBox.Text;
                    SendMessage(number12, message);
                    System.Threading.Thread.Sleep(500);
                    SMSCount = SMSCount + 1;
                }

                string EndText = "Meldingen blev sendt til alle modtagere i gruppe 12 med success. :)\n\n";
                LogViewer(EndText);
                SendUdkaldButton.Background = Brushes.Green;
                GruppeButton12.Background = Brushes.Red;
                MeldingTextBox.Text = "";
            }
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {

        }

        public void LogViewer(string text)
        {
            StatusBox1.AppendText(text);
            StatusBox1.ScrollToEnd();
        }
    }
}
