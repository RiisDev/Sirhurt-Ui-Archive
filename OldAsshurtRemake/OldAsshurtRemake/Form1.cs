using Newtonsoft.Json.Linq;
using ScintillaNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OldAsshurtRemake
{
    public partial class Main : Form
    {
        [DllImport("SirHurtInjector.dll")]
        private static extern int Inject();
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr FindWindowA(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);
        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern int FreeConsole();


        string ScriptPath = $"{AppDomain.CurrentDomain.BaseDirectory}\\Scripts";
        public List<JToken> LoadedScripts;

        private bool attached;
        private uint attachedID;
        private bool AttachedBackup;

        private void SetupScint()
        {
            scintilla.AllowDrop = true;
            scintilla.BorderStyle = BorderStyle.None;
            scintilla.Lexer = Lexer.Lua;
            scintilla.Styles[Style.Default].Font = "Consolas";
            scintilla.Styles[Style.Default].Size = 10;
            scintilla.StyleClearAll();

            scintilla.Styles[Style.Lua.Identifier].ForeColor = Color.Black;
            scintilla.Styles[Style.Lua.Comment].ForeColor = Color.FromArgb(74, 139, 69);
            scintilla.Styles[Style.Lua.CommentLine].ForeColor = Color.FromArgb(74, 139, 69);
            scintilla.Styles[Style.Lua.CommentDoc].ForeColor = Color.FromArgb(58, 64, 34);
            scintilla.Styles[Style.Lua.Number].ForeColor = Color.FromArgb(181, 206, 168);
            scintilla.Styles[Style.Lua.String].ForeColor = Color.FromArgb(193, 118, 76);
            scintilla.Styles[Style.Lua.Character].ForeColor = Color.FromArgb(193, 118, 76);
            scintilla.Styles[Style.Lua.LiteralString].ForeColor = Color.FromArgb(193, 118, 76);
            scintilla.Styles[Style.Lua.Operator].ForeColor = Color.Black;

            scintilla.SetProperty("fold", "1");
            scintilla.SetProperty("fold.compact", "0");

            scintilla.Margins[0].Width = 19;
            scintilla.Margins[0].Type = MarginType.Number;
            scintilla.Margins[1].Type = MarginType.Symbol;
            scintilla.Margins[1].Mask = 4261412864u;
            scintilla.Margins[1].Sensitive = true;
            scintilla.Margins[1].Width = 8;

            for (var i = 0; i <= 31; i++)
            {
                scintilla.Markers[i].SetForeColor(Color.White);
                scintilla.Markers[i].SetBackColor(Color.White);
            }

            scintilla.Markers[Marker.Folder].Symbol = MarkerSymbol.BoxPlus;
            scintilla.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.BoxMinus;
            scintilla.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.BoxPlusConnected;
            scintilla.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            scintilla.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.BoxMinusConnected;
            scintilla.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            scintilla.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;


            scintilla.AutomaticFold = AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change;
            scintilla.SetSelectionBackColor(true, Color.FromArgb(17, 177, 255));
            scintilla.SetSelectionForeColor(true, Color.Black);

            scintilla.Styles[Style.Lua.Word].ForeColor = Color.FromArgb(0, 0, 0, 127); // Logic
            scintilla.Styles[Style.Lua.Word2].ForeColor = Color.FromArgb(0, 255, 128, 0); // Globals
            scintilla.Styles[Style.Lua.Word3].ForeColor = Color.FromArgb(0, 255, 0, 0); // Functions
            scintilla.Styles[Style.Lua.Word4].ForeColor = Color.DarkSlateBlue; // Enums
            scintilla.SetKeywords(0, "and break do else elseif end false for function if in local nil not or repeat return then true until while continue [nonamecall]");
            scintilla.SetKeywords(1, "__add __call __concat __div __eq __index __le __len __lt __metatable __mod __mode __mul __newindex __pow __sub __tonumber __tostring __unm _G _VERSION assert collectgarbage dofile error getfenv getmetatable ipairs load loadfile loadstring module next pairs pcall print rawequal rawget rawset require select setfenv setmetatable tonumber tostring type unpack xpcall coroutine coroutine.create coroutine.resume coroutine.running coroutine.status create resume running status wrap yield debug getfenv gethook getinfo getlocal getmetatable getregistry getupvalue setfenv sethook setlocal setmetatable setupvalue traceback byte char dump find format gmatch gsub close flush input lines open output popen read stderr stdin stdout tmpfile type write abs acos asin atan atan2 ceil cos cosh deg exp floor fmod frexp huge ldexp log log10 max min modf pi pow rad random randomseed sin sinh sqrt tan tanh clock date difftime execute exit getenv remove rename setlocale time tmpname cpath loaded loaders loadlib path preload seeall len lower match rep reverse sub upper concat insert maxn remove sort coroutine.wrap coroutine.yield debug debug.debug debug.getfenv debug.gethook debug.getinfo debug.getlocal debug.getmetatable debug.getregistry debug.getupvalue debug.setfenv debug.sethook debug.setlocal debug.setmetatable debug.setupvalue debug.traceback io io.close io.flush io.input io.lines io.open io.output io.popen io.read io.stderr io.stdin io.stdout io.tmpfile io.type io.write math math.abs math.acos math.asin math.atan math.atan2 math.ceil math.cos math.cosh math.deg math.exp math.floor math.fmod math.frexp math.huge math.ldexp math.log math.log10 math.max math.min math.modf math.pi math.pow math.rad math.random math.randomseed math.sin math.sinh math.sqrt math.tan math.tanh os os.clock os.date os.difftime os.execute os.exit os.getenv os.remove os.rename os.setlocale os.time os.tmpname string string.byte string.char string.dump string.find string.format string.gmatch string.gsub string.len string.lower string.match string.rep string.reverse string.sub string.upper table table.concat table.insert table.maxn table.remove table.sort delay DebuggerManager elapsedTime LoadLibrary PluginManager printidentity require settings spawn stats tick time typeof UserSettings version wait warn bit32 bit32.arshift bit32.band bit32.bnot bit32.bor bit32.btest bit32.bxor bit32.extract bit32.replace bit32.lrotate bit32.lshift bi32.rrotate bit32.rshift utf8 utf8.codes utf8.char utf8.codepoint utf8.len utf8.offset utf8.graphemes utf8.nfcnormalize utf8.nfdnromalize utf8.charpattern Axes.new Axes BrickColor.Blue BrickColor.White BrickColor.Yellow BrickColor.Red BrickColor.Gray BrickColor.palette BrickColor.New BrickColor.Black BrickColor.Green BrickColor.Random BrickColor.DarkGray BrickColor.random BrickColor.new CFrame.lookAt CFrame.fromMatrix CFrame.fromAxisAngle CFrame.fromOrientation CFrame.fromEulerAnglesXYZ CFrame.Angles CFrame.fromEulerAnglesYXZ CFrame.new Color3.fromHSV Color3.toHSV Color3.fromRGB Color3.new ColorSequence.new DateTime.fromUnixTimestamp DateTime.now DateTime.fromIsoDate DateTime.fromUnixTimestampMillis DateTime.fromLocalTime DateTime.fromUniversalTime DockWidgetPluginGuiInfo.new Faces.new Instance.new NumberRange.new NumberSequence.new NumberSequenceKeypoint.new PathWaypoint.new PhysicalProperties.new Random.new Ray.new RaycastParams.new Rect.new RBXScriptSignal RBXScriptConnection Region3.new Region3int16.new TweenInfo.new UDim.new UDim2.fromOffset UDim2.fromScale UDim2.new Vector2.new Vector2int16.new Vector3.FromNormalId Vector3.FromAxis Vector3.fromAxis Vector3.fromNormalId Vector3.new Vector3int16.new Axes BrickColor CFrame Color3 ColorSequence ColorSequenceKeypoint DateTime DockWidgetPluginGuiInfo Enum EnumItem Enums Faces Instance NumberRange NumberSequence NumberSequenceKeypoint PathWaypoint PhysicalProperties Random Ray RaycastParams RaycastResult RBXScriptConnection RBXScriptSignal Rect Region3 Region3int16 TweenInfo UDim UDim2 Vector2 Vector2int16 Vector3 Vector3int16");
            scintilla.SetKeywords(2, "setnamecallmethod getnamecallmethod setfflag setclipboard appendfile writefile readfile checkcaller islclosure mousemoveabs mousemoverel mouse1release mouse1press mouse2click mouse1release mouse1press mouse1click isreadonly setreadonly setrawmetatable setrawmetatable debug.setmetatable getrawmetatable debug.getrawmetatable firetouchinterest fireclickdetector firesignal getconnections getnilinstances getgc getreg getrenv getgenv hookfunction hookfunc getregistry setstack getstack setconstant getconstant getconstants setupvalues getupvalues");
            scintilla.SetKeywords(3, "ABTestLoadingStatus ActionType ActuatorRelativeTo ActuatorType AdornCullingMode AlignType AlphaMode AnimationPriority AppShellActionType AspectType AssetFetchStatus AssetType AutoIndentRule AutomaticSize AvatarAssetType AvatarContextMenuOption AvatarItemType AvatarJointPositionType Axis BinType BodyPart BodyPartR15 BorderMode BreakReason BulkMoveMode BundleType Button ButtonStyle CameraMode CameraPanMode CameraType CatalogCategoryFilter CatalogSortType CellBlock CellMaterial CellOrientation CenterDialogType ChatColor ChatMode ChatPrivacyMode ChatStyle CollisionFidelity ComputerCameraMovementMode ComputerMovementMode ConnectionError ConnectionState ContextActionPriority ContextActionResult ControlMode CoreGuiType CreatorType CurrencyType CustomCameraModeDataStoreRequestType DevCameraOcclusionMode DevComputerCameraMovementMode DevComputerMovementMode DeveloperMemoryTag DeviceType DevTouchCameraMovementMode DevTouchMovementMode DialogBehaviorType DialogPurpose DialogTone DominantAxis DraftStatusCode EasingDirection EasingStyle ElasticBehavior EnviromentalPhysicsThrottle ExplosionType FieldOfViewMode FillDirection FilterResult Font FontSize FormFactor FramerateManagerMode FrameStyle FriendRequestEvent FriendStatus FunctionalTestResult GameAvatarType GearGenreSetting GearType Genre GraphicsMode HandlesStyle HorizontalAlignment HoverAnimateSpeed HttpCachePolicy HttpContentType HttpError HttpRequestType HumanoidCollisionType HumanoidDisplayDistanceType HumanoidHealthDisplayType HumanoidRigType HumanoidStateType IKCollisionsMode InfoType InitialDockState InOut InputType InterpolationThrottlingMode JointCreationMode KeyCode KeywordFilterType Language LanguagePreference LeftRight LevelOfDetailSetting Limb ListDisplayMode ListenerType Material MembershipType MeshPartDetailLevel MeshPartHeads MeshType MessageType ModelLevelOfDetail ModifierKey MouseBehavior MoveState NameOcclusion NetworkOwnership NormalId OutputLayoutMode OverrideMouseIconBehavior PacketPriority PartType PathStatus PathWaypointAction PermissionLevelShown PhysicsSimulationRate Platform PlaybackState PlayerActions PlayerChatType PoseEasingDirection PoseEasingStyle PrivilegeType ProductPurchaseDecision QualityLevel R15CollisionType RaycastFilterType RenderFidelity RenderingTestComparisonMethod RenderPriority ReturnKeyType ReverbType RibbonTool RollOffMode RotationType RuntimeUndoBehavior SavedQualitySetting SaveFilter ScaleType ScreenOrientation ScrollBarInset ScrollingDirection ServerAudioBehavior SizeConstraint SortOrder SoundType SpecialKey StartCorner Status StreamingPauseMode StudioDataModelType StudioScriptEditorColorCategories StudioScriptEditorColorPresets StudioStyleGuideColor StudioStyleGuideModifier Style SurfaceConstraint SurfaceGuiSizingMode SurfaceType SwipeDirection TableMajorAxis Technology TeleportMethod TeleportResult TeleportState TeleportType TextFilterContext TextInputType TextTruncate TextureMode TextureQueryType TextXAlignment TextYAlignment ThreadPoolConfig ThrottlingPriority ThumbnailSize ThumbnailType TickCountSampleMethod TopBottom TouchCameraMovementMode TouchMovementMode TriStateBoolean TweenStatus UiMessageType UITheme UserCFrame UserInputState UserInputType VerticalAlignment VerticalScrollBarPosition VibrationMotor VirtualInputMode VRTouchpad VRTouchpadMode WaterDirection WaterForce ZIndexBehavior");

            scintilla.TabWidth = 0; 

            scintilla.TextChanged += (e, r) =>
            {
                var lineCount = scintilla.Lines.Count.ToString().Length;
                scintilla.Margins[0].Width = scintilla.TextWidth(10, new string('9', lineCount + 1)) + 1;
            };

            scintilla.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Tab)
                    scintilla.AddText("\t");
            };
        }

        public Main()
        {
            InitializeComponent();
            SetupScint();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://twitch.tv/IrisDev");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            scintilla.Text = "";
        }

        private void LoadFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog diag = new OpenFileDialog())
            {
                diag.CheckFileExists = true;
                diag.CheckPathExists = true;
                diag.Filter = "All Files * | *.*";

                DialogResult result = diag.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (File.Exists(diag.FileName))
                    {
                        scintilla.Text = File.ReadAllText(diag.FileName);
                    }
                }
            }
        }

        private void ExecButton_Click(object sender, EventArgs e)
        {
            ExecuteScript(scintilla.Text);
        }

        private void ScriptLoad()
        {
            Directory.CreateDirectory(ScriptPath);
            listBox1.Items.Clear();

            foreach (string FileDat in Directory.GetFiles(ScriptPath))
            {
                listBox1.Items.Add(FileDat.Replace($"{ScriptPath}\\", ""));
            }
        }

        private void ExecuteScript(string scr)
        {
            using (StreamWriter writer = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}\\sirhurt.dat"))
            {
                writer.Write(scr);
                Console.WriteLine(scr);
            }
        }

        public string httpGet(string link)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(link);
            httpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            string result;
            using (var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                using (var responseStream = httpWebResponse.GetResponseStream())
                {
                    using (var streamReader = new StreamReader(responseStream))
                    {
                        result = streamReader.ReadToEnd();
                    }
                }
            }

            return result;
        }

        private JObject JsonDecode(string Json)
        {
            return JObject.Parse(Json);
        }

        public static string RandomString(int maxSize)
        {
            var array = new char[62];
            array = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            var array2 = new byte[1];
            using (var rngcryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                rngcryptoServiceProvider.GetNonZeroBytes(array2);
                array2 = new byte[maxSize];
                rngcryptoServiceProvider.GetNonZeroBytes(array2);
            }

            var stringBuilder = new StringBuilder(maxSize);
            foreach (var b in array2) stringBuilder.Append(array[b % array.Length]);
            return stringBuilder.ToString();
        }

        private void LoadOnlineScripts()
        {
            try
            {
                var json = httpGet("https://sirhurt.net/upl/UIScriptHub/fetch.php");
                var list2 = JsonDecode(json)["scripts"].Children().Children().ToList();

                LoadedScripts = list2;

                foreach (var jtoken in list2)
                {
                    scriptsToolStripMenuItem.DropDownItems.Add(jtoken["Name"].ToString());
                }

                foreach (ToolStripItem Item in scriptsToolStripMenuItem.DropDownItems)
                {
                    Item.Click += (sender, e) =>
                    {
                        foreach (var jtoken in LoadedScripts)
                            if (jtoken["Name"].ToString() == Item.Text)
                            {
                                string Text = jtoken["FileName"].ToString();
                                ExecuteScript($"loadstring(HttpGet('https://sirhurt.net/upl/UIScriptHub/Scripts/script.php?script={Text}'))()");
                            }
                    };
                }
            }
            catch
            {}
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Name = RandomString(5);
            Text = RandomString(5);
            ScriptLoad();
            LoadOnlineScripts();
            InjectListener();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null || listBox1.SelectedIndex < 0)
                return;

            scintilla.Text = File.ReadAllText($"{ScriptPath}\\{listBox1.SelectedItem}");

            listBox1.SelectedItem = null;
        }

        private void executeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null || listBox1.SelectedIndex < 0)
                return;

            ExecuteScript(File.ReadAllText($"{ScriptPath}\\{listBox1.SelectedItem}"));

            listBox1.SelectedItem = null;
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null || listBox1.SelectedIndex < 0)
                return;

            scintilla.Text = File.ReadAllText($"{ScriptPath}\\{listBox1.SelectedItem}");

            listBox1.SelectedItem = null;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.CheckPathExists = true;
                save.InitialDirectory = ScriptPath;
                save.Filter = "All Files * | *.*";

                DialogResult diag = save.ShowDialog();

                if (diag == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(save.FileName))
                    {
                        writer.Write(scintilla.Text);
                    }
                }
            }
            ScriptLoad();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScriptLoad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InjectSirHurt();
        }
        public void InjectSirHurt()
        {
            new Thread(delegate ()
            {
                try
                {
                    var intPtr = FindWindowA("WINDOWSCLIENT", "Roblox");

                    if (!attached && intPtr != IntPtr.Zero)
                    {
                        var num = 0;
                        try
                        {
                            num = Inject();
                        }
                        catch (Exception ex)
                        {
                            attached = false;
                            button1.Invoke(new Action(() => {
                                button1.ForeColor = Color.Red;
                                button1.Text = "Not Attached";
                            }));
                            MessageBox.Show($"An error occured with injecting SirHurt: {ex.Message}", "SirHurt V4");
                        }

                        if (num != 0)
                        {
                            attached = true;
                            AttachedBackup = true;
                            return;
                        }

                        attached = false;
                        button1.Invoke(new Action(() => {
                            button1.ForeColor = Color.Red;
                            button1.Text = "Not Attached";
                        }));
                    }
                }
                catch (Exception ex)
                {
                    attached = false;
                    button1.Invoke(new Action(() => {
                        button1.ForeColor = Color.Red;
                        button1.Text = "Not Attached";
                    }));
                    MessageBox.Show($"An error occured with injecting SirHurt: {ex.Message}", "SirHurt V4");
                }

            }).Start();
        }

        private void InjectListener()
        {
            new Thread(async () =>
            {
                var Server = new NamedPipeServerStream("SirHurtI", PipeDirection.InOut, 1, PipeTransmissionMode.Byte, PipeOptions.None, 0, 0);
                Server.WaitForConnection();

                StreamReader streamReader = new StreamReader(Server);

                for (; ; )
                {

                    string Data = "";
                    try
                    {
                        Data = streamReader.ReadLine();
                    }
                    catch
                    {
                        Data = "SIR_NOT_READY";
                    }

                    if (Data == "SH_DONE")
                    {
                        button1.Invoke(new Action(() =>
                        {
                            button1.ForeColor = Color.Green;
                            button1.Text = "Attached!";
                        }));
                        AttachedBackup = true;
                    }

                    if (attached && AttachedBackup)
                    {
                        button1.Invoke(new Action(() =>
                        {
                            button1.ForeColor = Color.Green;
                            button1.Text = "Attached!";
                        }));
                    }
                    else
                    {
                        await Task.Delay(100);
                        button1.Invoke(new Action(() =>
                        {
                            button1.ForeColor = Color.Red;
                            button1.Text = "Not Attached";
                        }));

                        Server.Close();
                        Server = new NamedPipeServerStream("SirHurtI", PipeDirection.InOut, 1, PipeTransmissionMode.Byte, PipeOptions.None, 0, 0);
                        Server.WaitForConnection();

                        streamReader = new StreamReader(Server);
                    }
                    await Task.Delay(50);
                }
            }).Start();

            new Thread(async () =>
            {
                for (; ; )
                {
                    if (Process.GetProcessesByName("RobloxPlayerBeta").Length == 0)
                    {
                        button1.Invoke(new Action(() =>
                        {
                            button1.ForeColor = Color.Red;
                            button1.Text = "Not Attached";
                        }));
                    }
                    await Task.Delay(500);
                }
            }).Start();
        }
    }
}
