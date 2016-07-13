using Nikse.SubtitleEdit.Core;
using Nikse.SubtitleEdit.Logic.VideoPlayers;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Nikse.SubtitleEdit.Controls
{
    public sealed class VideoPlayerContainer : Panel
    {

        //public class richtextboxviewonly : richtextbox
        //{
        //    public richtextboxviewonly()
        //    {
        //        readonly = true;
        //        borderstyle = borderstyle.none;
        //        tabstop = false;
        //        setstyle(controlstyles.selectable, false);
        //        setstyle(controlstyles.usermouse, true);
        //        mouseenter += delegate { cursor = cursors.default; };
        //        scrollbars = richtextboxscrollbars.none;
        //        margin = new padding(0);
        //    }

        //    protected override void wndproc(ref message m)
        //    {
        //        if (m.msg == 0x204) return; // wm_rbuttondown
        //        if (m.msg == 0x205) return; // wm_rbuttonup
        //        base.wndproc(ref m);
        //    }
        //}

        public class RichTextBoxViewOnlyUpperTop : RichTextBox
        {
            public RichTextBoxViewOnlyUpperTop()
            {
                ReadOnly = true;
                BorderStyle = BorderStyle.None;
                TabStop = false;
                SetStyle(ControlStyles.Selectable, false);
                SetStyle(ControlStyles.UserMouse, true);
                MouseEnter += delegate { Cursor = Cursors.Default; };
                ScrollBars = RichTextBoxScrollBars.None;
                Margin = new Padding(0);
                WordWrap = false;
            }

            protected override void WndProc(ref Message m)
            {
                if (m.Msg == 0x204) return; // WM_RBUTTONDOWN
                if (m.Msg == 0x205) return; // WM_RBUTTONUP
                base.WndProc(ref m);
            }
        }

        public class RichTextBoxViewOnlyUpperTopLeft : RichTextBox
        {
            public RichTextBoxViewOnlyUpperTopLeft()
            {
                ReadOnly = true;
                BorderStyle = BorderStyle.None;
                TabStop = false;
                SetStyle(ControlStyles.Selectable, false);
                SetStyle(ControlStyles.UserMouse, true);
                MouseEnter += delegate { Cursor = Cursors.Default; };
                ScrollBars = RichTextBoxScrollBars.None;
                Margin = new Padding(0);
                WordWrap = false;
            }

            protected override void WndProc(ref Message m)
            {
                if (m.Msg == 0x204) return; // WM_RBUTTONDOWN
                if (m.Msg == 0x205) return; // WM_RBUTTONUP
                base.WndProc(ref m);
            }
        }

        public class RichTextBoxViewOnlyUpperTopRight : RichTextBox
        {
            public RichTextBoxViewOnlyUpperTopRight()
            {
                ReadOnly = true;
                BorderStyle = BorderStyle.None;
                TabStop = false;
                SetStyle(ControlStyles.Selectable, false);
                SetStyle(ControlStyles.UserMouse, true);
                MouseEnter += delegate { Cursor = Cursors.Default; };
                ScrollBars = RichTextBoxScrollBars.None;
                Margin = new Padding(0);
                WordWrap = false;
            }

            protected override void WndProc(ref Message m)
            {
                if (m.Msg == 0x204) return; // WM_RBUTTONDOWN
                if (m.Msg == 0x205) return; // WM_RBUTTONUP
                base.WndProc(ref m);
            }
        }

        public class RichTextBoxViewOnlyUpperCenter : RichTextBox
        {
            public RichTextBoxViewOnlyUpperCenter()
            {
                ReadOnly = true;
                BorderStyle = BorderStyle.None;
                TabStop = false;
                SetStyle(ControlStyles.Selectable, false);
                SetStyle(ControlStyles.UserMouse, true);
                MouseEnter += delegate { Cursor = Cursors.Default; };
                ScrollBars = RichTextBoxScrollBars.None;
                Margin = new Padding(0);
                WordWrap = false;
            }

            protected override void WndProc(ref Message m)
            {
                if (m.Msg == 0x204) return; // WM_RBUTTONDOWN
                if (m.Msg == 0x205) return; // WM_RBUTTONUP
                base.WndProc(ref m);
            }
        }

        public class RichTextBoxViewOnlyBottomLeft : RichTextBox
        {
            public RichTextBoxViewOnlyBottomLeft()
            {
                ReadOnly = true;
                BorderStyle = BorderStyle.None;
                TabStop = false;
                SetStyle(ControlStyles.Selectable, false);
                SetStyle(ControlStyles.UserMouse, true);
                MouseEnter += delegate { Cursor = Cursors.Default; };
                ScrollBars = RichTextBoxScrollBars.None;
                Margin = new Padding(0);
                WordWrap = false;
            }

            protected override void WndProc(ref Message m)
            {
                if (m.Msg == 0x204) return; // WM_RBUTTONDOWN
                if (m.Msg == 0x205) return; // WM_RBUTTONUP
                base.WndProc(ref m);
            }
        }

        public class RichTextBoxViewOnlyBottomRight : RichTextBox
        {
            public RichTextBoxViewOnlyBottomRight()
            {
                ReadOnly = true;
                BorderStyle = BorderStyle.None;
                TabStop = false;
                SetStyle(ControlStyles.Selectable, false);
                SetStyle(ControlStyles.UserMouse, true);
                MouseEnter += delegate { Cursor = Cursors.Default; };
                ScrollBars = RichTextBoxScrollBars.None;
                Margin = new Padding(0);
                WordWrap = false;
            }

            protected override void WndProc(ref Message m)
            {
                if (m.Msg == 0x204) return; // WM_RBUTTONDOWN
                if (m.Msg == 0x205) return; // WM_RBUTTONUP
                base.WndProc(ref m);
            }
        }

        public class RichTextBoxViewOnlyUpper : RichTextBox
        {
            public RichTextBoxViewOnlyUpper()
            {
                ReadOnly = true;
                BorderStyle = BorderStyle.None;
                TabStop = false;
                SetStyle(ControlStyles.Selectable, false);
                SetStyle(ControlStyles.UserMouse, true);
                MouseEnter += delegate { Cursor = Cursors.Default; };
                ScrollBars = RichTextBoxScrollBars.None;
                Margin = new Padding(0);
                WordWrap = false;
            }

            protected override void WndProc(ref Message m)
            {
                if (m.Msg == 0x204) return; // WM_RBUTTONDOWN
                if (m.Msg == 0x205) return; // WM_RBUTTONUP
                base.WndProc(ref m);
            }
        }


        public event EventHandler OnButtonClicked;
        public Panel PanelPlayer { get; private set; }
        //private Panel _panelSubtitle;
        private Panel _panelSubtitleUpper;
        //private RichTextBoxViewOnly _subtitleTextBox;
        private RichTextBoxViewOnlyUpper _subtitleTextBoxUpper;
        private RichTextBoxViewOnlyUpperTop _subtitleTextBoxUpperTop;
        private RichTextBoxViewOnlyUpperTopLeft _subtitleTextBoxUpperTopLeft;
        private RichTextBoxViewOnlyUpperTopRight _subtitleTextBoxUpperTopRight;
        private RichTextBoxViewOnlyUpperCenter _subtitleTextBoxUpperCenter;
        private RichTextBoxViewOnlyBottomLeft _subtitleTextBoxBottomLeft;
        private RichTextBoxViewOnlyBottomRight _subtitleTextBoxBottomRight;
        //private string _subtitleText = string.Empty;
        private string _subtitleTextUpper = string.Empty;
        private string _subtitleTextUpperTop = string.Empty;
        private string _subtitleTextUpperTopLeft = string.Empty;
        private string _subtitleTextUpperTopRight = string.Empty;
        private string _subtitleTextUpperCenter = string.Empty;
        private string _subtitleTextBottomLeft = string.Empty;
        private string _subtitleTextBottomRight = string.Empty;

        private VideoPlayer _videoPlayer;

        public float FontSizeFactor { get; set; }

        public VideoPlayer VideoPlayer
        {
            get { return _videoPlayer; }
            set
            {
                _videoPlayer = value;
                if (_videoPlayer != null)
                    SetPlayerName(_videoPlayer.PlayerName);
            }
        }

        //public RichTextBoxViewOnly TextBox
        //{
        //    get { return _subtitleTextBox; }
        //}

        public RichTextBoxViewOnlyUpper TextBoxUpper
        {
            get { return _subtitleTextBoxUpper; }
        }

        public RichTextBoxViewOnlyUpperTop TextBoxUpperTop
        {
            get { return _subtitleTextBoxUpperTop; }
        }

        public RichTextBoxViewOnlyUpperTopLeft TextBoxUpperTopLeft
        {
            get { return _subtitleTextBoxUpperTopLeft; }
        }

        public RichTextBoxViewOnlyUpperTopRight TextBoxUpperTopRight
        {
            get { return _subtitleTextBoxUpperTopRight; }
        }

        public RichTextBoxViewOnlyUpperCenter TextBoxUpperCenter
        {
            get { return _subtitleTextBoxUpperCenter; }
        }

        public RichTextBoxViewOnlyBottomLeft TextBoxBottomLeft
        {
            get { return _subtitleTextBoxBottomLeft; }
        }

        public RichTextBoxViewOnlyBottomRight TextBoxBottomRight
        {
            get { return _subtitleTextBoxBottomRight; }
        }

        public int VideoWidth { get; set; }
        public int VideoHeight { get; set; }

        private bool _isMuted;
        private double? _muteOldVolume;
        private readonly System.ComponentModel.ComponentResourceManager _resources;
        private int _controlsHeight = 47;
        private const int SubtitlesHeight = 0;
        private const int SubtitlesHeightUpper = 40;
        private const int SubtitlesHeightUpperTop = 40;
        private const int SubtitlesHeightUpperTopLeft = 40;
        private const int SubtitlesHeightUpperTopRight = 40;
        private const int SubtitlesHeightUpperCenter = 40;
        private const int SubtitlesHeightBottomLeft = 40;
        private const int SubtitlesHeightBottomRight = 40;
        private readonly Color _backgroundColor = Color.FromArgb(5, 5, 5);
        //private readonly Color _backgroundColor = Color.Black;
        private Panel _panelcontrols;

        private PictureBox _pictureBoxBackground;
        private PictureBox _pictureBoxReverse;
        private PictureBox _pictureBoxReverseOver;
        private PictureBox _pictureBoxReverseDown;
        private PictureBox _pictureBoxFastForward;
        private PictureBox _pictureBoxFastForwardOver;
        private PictureBox _pictureBoxFastForwardDown;
        private PictureBox _pictureBoxPlay;
        private PictureBox _pictureBoxPlayOver;
        private PictureBox _pictureBoxPlayDown;
        private readonly PictureBox _pictureBoxPause = new PictureBox();
        private readonly PictureBox _pictureBoxPauseOver = new PictureBox();
        private readonly PictureBox _pictureBoxPauseDown = new PictureBox();
        private readonly PictureBox _pictureBoxStop = new PictureBox();
        private readonly PictureBox _pictureBoxStopOver = new PictureBox();
        private readonly PictureBox _pictureBoxStopDown = new PictureBox();
        private readonly PictureBox _pictureBoxFullscreen = new PictureBox();
        private readonly PictureBox _pictureBoxFullscreenOver = new PictureBox();
        private readonly PictureBox _pictureBoxFullscreenDown = new PictureBox();
        private readonly PictureBox _pictureBoxMute = new PictureBox();
        private readonly PictureBox _pictureBoxMuteOver = new PictureBox();
        private readonly PictureBox _pictureBoxMuteDown = new PictureBox();
        private readonly PictureBox _pictureBoxProgressbarBackground = new PictureBox();
        private readonly PictureBox _pictureBoxProgressBar = new PictureBox();
        private readonly PictureBox _pictureBoxVolumeBarBackground = new PictureBox();
        private readonly PictureBox _pictureBoxVolumeBar = new PictureBox();
        private readonly Label _labelTimeCode = new Label();
        private readonly Label _labelVideoPlayerName = new Label();

        //public RightToLeft TextRightToLeft
        //{
        //    get
        //    {
        //        return _subtitleTextBox.RightToLeft;
        //    }
        //    set
        //    {
        //        _subtitleTextBox.RightToLeft = value;
        //        _subtitleTextBox.SelectAll();
        //        _subtitleTextBox.SelectionAlignment = HorizontalAlignment.Center;
        //    }
        //}

        public RightToLeft TextUpperRightToLeft
        {
            get
            {
                return _subtitleTextBoxUpper.RightToLeft;
            }
            set
            {
                _subtitleTextBoxUpper.RightToLeft = value;
                _subtitleTextBoxUpper.SelectAll();
                _subtitleTextBoxUpper.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        public RightToLeft TextTopRightToLeft
        {
            get
            {
                return _subtitleTextBoxUpperTop.RightToLeft;
            }
            set
            {
                _subtitleTextBoxUpperTop.RightToLeft = value;
                _subtitleTextBoxUpperTop.SelectAll();
                _subtitleTextBoxUpperTop.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        public RightToLeft TextTopLeftRightToLeft
        {
            get
            {
                return _subtitleTextBoxUpperTopLeft.RightToLeft;
            }
            set
            {
                _subtitleTextBoxUpperTopLeft.RightToLeft = value;
                _subtitleTextBoxUpperTopLeft.SelectAll();
                _subtitleTextBoxUpperTopLeft.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        public RightToLeft TextTopRightRightToLeft
        {
            get
            {
                return _subtitleTextBoxUpperTopRight.RightToLeft;
            }
            set
            {
                _subtitleTextBoxUpperTopRight.RightToLeft = value;
                _subtitleTextBoxUpperTopRight.SelectAll();
                _subtitleTextBoxUpperTopRight.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        public RightToLeft TextCenterRightToLeft
        {
            get
            {
                return _subtitleTextBoxUpperCenter.RightToLeft;
            }
            set
            {
                _subtitleTextBoxUpperCenter.RightToLeft = value;
                _subtitleTextBoxUpperCenter.SelectAll();
                _subtitleTextBoxUpperCenter.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        public RightToLeft TextBottomLeftRightToLeft
        {
            get
            {
                return _subtitleTextBoxBottomLeft.RightToLeft;
            }
            set
            {
                _subtitleTextBoxBottomLeft.RightToLeft = value;
                _subtitleTextBoxBottomLeft.SelectAll();
                _subtitleTextBoxBottomLeft.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        public RightToLeft TextBottomRightRightToLeft
        {
            get
            {
                return _subtitleTextBoxBottomRight.RightToLeft;
            }
            set
            {
                _subtitleTextBoxBottomRight.RightToLeft = value;
                _subtitleTextBoxBottomRight.SelectAll();
                _subtitleTextBoxBottomRight.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        public bool ShowStopButton
        {
            get
            {
                return _pictureBoxStop.Visible || _pictureBoxStopOver.Visible || _pictureBoxStopDown.Visible;
            }
            set
            {
                if (value)
                {
                    _pictureBoxStop.Visible = true;
                }
                else
                {
                    HideAllStopImages();
                }
            }
        }

        public bool ShowMuteButton
        {
            get
            {
                return _pictureBoxMute.Visible || _pictureBoxMuteOver.Visible || _pictureBoxMuteDown.Visible;
            }
            set
            {
                if (value)
                {
                    _pictureBoxMute.Visible = true;
                }
                else
                {
                    HideAllMuteImages();
                }
            }
        }

        public bool ShowFullscreenButton
        {
            get
            {
                return _pictureBoxFullscreen.Visible || _pictureBoxFullscreenOver.Visible || _pictureBoxFullscreenDown.Visible;
            }
            set
            {
                if (value)
                {
                    _pictureBoxFullscreen.Visible = true;
                }
                else
                {
                    HideAllFullscreenImages();
                }
            }
        }

        public VideoPlayerContainer()
        {
            FontSizeFactor = 1.0F;
            BorderStyle = BorderStyle.None;
            _resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoPlayerContainer));
            BackColor = _backgroundColor;

            Controls.Add(MakeSubtitlesPanelUpperTop());
            Controls.Add(MakeSubtitlesPanelUpperTopLeft());
            Controls.Add(MakeSubtitlesPanelUpperTopRight());
            Controls.Add(MakeSubtitlesPanelUpperCenter());
            Controls.Add(MakeSubtitlesPanelBottomLeft());
            Controls.Add(MakeSubtitlesPanelBottomRight());
            Controls.Add(MakeSubtitlesPanelUpper());
            Controls.Add(MakePlayerPanel());
            //Controls.Add(MakeSubtitlesPanel());
            Controls.Add(MakeControlsPanel());

            //_panelcontrols.SendToBack();
            //PanelPlayer.SendToBack();
            //_subtitleTextBox.BringToFront();
            //_subtitleTextBoxUpper.BringToFront();
                        
            HideAllPlayImages();
            HideAllPauseImages();
            _pictureBoxPlay.Visible = true;
            _pictureBoxPlay.BringToFront();

            HideAllStopImages();
            _pictureBoxStop.Visible = true;

            HideAllFullscreenImages();
            _pictureBoxFullscreen.Visible = true;

            HideAllMuteImages();
            _pictureBoxMute.Visible = true;

            HideAllReverseImages();
            _pictureBoxReverse.Visible = true;

            HideAllFastForwardImages();
            _pictureBoxFastForward.Visible = true;

            VideoPlayerContainerResize(this, null);
            Resize += VideoPlayerContainerResize;

            _pictureBoxProgressBar.Width = 0;

            PanelPlayer.MouseDown += PanelPlayerMouseDown;
        }

        public void EnableMouseWheelStep()
        {
            AddMouseWheelEvent(this);
        }

        public void SetPlayerName(string s)
        {
            _labelVideoPlayerName.Text = s;
            _labelVideoPlayerName.Left = Width - _labelVideoPlayerName.Width - 3;
        }

        public void ResetTimeLabel()
        {
            _labelTimeCode.Text = string.Empty;
        }

        private void AddMouseWheelEvent(Control control)
        {
            control.MouseWheel += ControlMouseWheel;
            foreach (Control ctrl in control.Controls)
                AddMouseWheelEvent(ctrl);
        }

        private void ControlMouseWheel(object sender, MouseEventArgs e)
        {
            int delta = e.Delta;
            double newPosition = CurrentPosition - (delta / 256.0);
            if (newPosition < 0)
                newPosition = 0;
            else if (newPosition > Duration)
                newPosition = Duration;
            CurrentPosition = newPosition;
        }

        private Control MakeSubtitlesPanelUpper()
        {
            //_panelSubtitleUpper = new Panel {BackColor =  _backgroundColor, Left = 0, Top = 0 , Height = SubtitlesHeightUpper + 1 };
            ////_panelSubtitleUpper.Location = new Point(200, 200);
            _subtitleTextBoxUpper = new RichTextBoxViewOnlyUpper();
            //_subtitleTextBoxUpper.Location = new Point(200, 150);
            _subtitleTextBoxUpper.BackColor = _backgroundColor;
            //_subtitleTextBoxUpper.ForeColor = Color.White;
            _subtitleTextBoxUpper.ForeColor = Color.Transparent;
            _subtitleTextBoxUpper.Dock = DockStyle.Fill;
            //_subtitleTextBoxUpper.Anchor = Bottom;
            SetSubtitleFontUpper();
            _subtitleTextBoxUpper.MouseClick += SubtitleTextBoxUpperMouseClick;
            _subtitleTextBoxUpper.ContentsResized += SubtitleTextBoxUpper_ContentsResized;
            //_panelSubtitleUpper.Controls.Add(_subtitleTextBoxUpper);
            _subtitleTextBoxUpper.Anchor = (AnchorStyles.Bottom);
            return _subtitleTextBoxUpper;
        }

        private Control MakeSubtitlesPanelUpperTop()
        {
            _subtitleTextBoxUpperTop = new RichTextBoxViewOnlyUpperTop();
            _subtitleTextBoxUpperTop.BackColor = _backgroundColor;
            _subtitleTextBoxUpperTop.ForeColor = Color.Transparent;
            _subtitleTextBoxUpperTop.Dock = DockStyle.Fill;
            SetSubtitleFontUpperTop();
            _subtitleTextBoxUpperTop.MouseClick += SubtitleTextBoxUpperTopMouseClick;
            _subtitleTextBoxUpperTop.ContentsResized += SubtitleTextBoxUpperTop_ContentsResized;
            _subtitleTextBoxUpperTop.Anchor = (AnchorStyles.Top);
            return _subtitleTextBoxUpperTop;
        }

        private Control MakeSubtitlesPanelUpperTopLeft()
        {
            _subtitleTextBoxUpperTopLeft = new RichTextBoxViewOnlyUpperTopLeft();
            _subtitleTextBoxUpperTopLeft.BackColor = _backgroundColor;
            _subtitleTextBoxUpperTopLeft.ForeColor = Color.Transparent;
            _subtitleTextBoxUpperTopLeft.Dock = DockStyle.None;
            SetSubtitleFontUpperTopLeft();
            _subtitleTextBoxUpperTopLeft.MouseClick += SubtitleTextBoxUpperTopLeftMouseClick;
            _subtitleTextBoxUpperTopLeft.ContentsResized += SubtitleTextBoxUpperTopLeft_ContentsResized;
            _subtitleTextBoxUpperTopLeft.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            return _subtitleTextBoxUpperTopLeft;
        }

        private Control MakeSubtitlesPanelUpperTopRight()
        {
            _subtitleTextBoxUpperTopRight = new RichTextBoxViewOnlyUpperTopRight();
            _subtitleTextBoxUpperTopRight.BackColor = _backgroundColor;
            _subtitleTextBoxUpperTopRight.ForeColor = Color.Transparent;
            _subtitleTextBoxUpperTopRight.Dock = DockStyle.Fill;
            SetSubtitleFontUpperTopRight();
            _subtitleTextBoxUpperTopRight.MouseClick += SubtitleTextBoxUpperTopRightMouseClick;
            _subtitleTextBoxUpperTopRight.ContentsResized += SubtitleTextBoxUpperTopRight_ContentsResized;
            _subtitleTextBoxUpperTopRight.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            return _subtitleTextBoxUpperTopRight;
        }

        private Control MakeSubtitlesPanelUpperCenter()
        {
            _subtitleTextBoxUpperCenter = new RichTextBoxViewOnlyUpperCenter();
            _subtitleTextBoxUpperCenter.BackColor = _backgroundColor;
            _subtitleTextBoxUpperCenter.ForeColor = Color.Transparent;
            _subtitleTextBoxUpperCenter.Dock = DockStyle.Fill;
            SetSubtitleFontUpperCenter();
            _subtitleTextBoxUpperCenter.MouseClick += SubtitleTextBoxUpperCenterMouseClick;
            _subtitleTextBoxUpperCenter.ContentsResized += SubtitleTextBoxUpperCenter_ContentsResized;
            _subtitleTextBoxUpperCenter.Anchor = (AnchorStyles.Left & AnchorStyles.Right & AnchorStyles.Bottom);
            return _subtitleTextBoxUpperCenter;
        }

        private Control MakeSubtitlesPanelBottomLeft()
        {
            _subtitleTextBoxBottomLeft = new RichTextBoxViewOnlyBottomLeft();
            _subtitleTextBoxBottomLeft.BackColor = _backgroundColor;
            _subtitleTextBoxBottomLeft.ForeColor = Color.Transparent;
            _subtitleTextBoxBottomLeft.Dock = DockStyle.Fill;
            SetSubtitleFontBottomLeft();
            _subtitleTextBoxBottomLeft.MouseClick += SubtitleTextBoxBottomLeftMouseClick;
            _subtitleTextBoxBottomLeft.ContentsResized += SubtitleTextBoxBottomLeft_ContentsResized;
            _subtitleTextBoxBottomLeft.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            return _subtitleTextBoxBottomLeft;
        }

        private Control MakeSubtitlesPanelBottomRight()
        {
            _subtitleTextBoxBottomRight = new RichTextBoxViewOnlyBottomRight();
            _subtitleTextBoxBottomRight.BackColor = _backgroundColor;
            _subtitleTextBoxBottomRight.ForeColor = Color.Transparent;
            _subtitleTextBoxBottomRight.Dock = DockStyle.Fill;
            SetSubtitleFontBottomRight();
            _subtitleTextBoxBottomRight.MouseClick += SubtitleTextBoxBottomRightMouseClick;
            _subtitleTextBoxBottomRight.ContentsResized += SubtitleTextBoxBottomRight_ContentsResized;
            _subtitleTextBoxBottomRight.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            return _subtitleTextBoxBottomRight;
        }

        private void SubtitleTextBoxUpper_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            const int margin = -1;
            RichTextBox rch = sender as RichTextBox;
            rch.ClientSize = new Size(
                e.NewRectangle.Width + margin,
                e.NewRectangle.Height + margin);
        }

        private void SubtitleTextBoxUpperTop_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            const int margin = -1;
            RichTextBox rch = sender as RichTextBox;
            rch.ClientSize = new Size(
                e.NewRectangle.Width + margin,
                e.NewRectangle.Height + margin);
        }

        private void SubtitleTextBoxUpperTopLeft_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            const int margin = -1;
            RichTextBox rch = sender as RichTextBox;
            rch.ClientSize = new Size(
                e.NewRectangle.Width + margin,
                e.NewRectangle.Height + margin);
        }

        private void SubtitleTextBoxUpperTopRight_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            const int margin = -1;
            RichTextBox rch = sender as RichTextBox;
            rch.ClientSize = new Size(
                e.NewRectangle.Width + margin,
                e.NewRectangle.Height + margin);
        }

        private void SubtitleTextBoxUpperCenter_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            const int margin = -1;
            RichTextBox rch = sender as RichTextBox;
            rch.ClientSize = new Size(
                e.NewRectangle.Width + margin,
                e.NewRectangle.Height + margin);
        }

        private void SubtitleTextBoxBottomLeft_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            const int margin = -1;
            RichTextBox rch = sender as RichTextBox;
            rch.ClientSize = new Size(
                e.NewRectangle.Width + margin,
                e.NewRectangle.Height + margin);
        }

        private void SubtitleTextBoxBottomRight_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            const int margin = -1;
            RichTextBox rch = sender as RichTextBox;
            rch.ClientSize = new Size(
                e.NewRectangle.Width + margin,
                e.NewRectangle.Height + margin);
        }

        //private Control MakeSubtitlesPanel()
        //{
        //    //_panelSubtitle = new Panel { BackColor = _backgroundColor, Left = 0, Top = 0, Height = 0 };
        //    //    _subtitleTextBox = new RichTextBoxViewOnly();
        //    //    _subtitleTextBox.BackColor = _backgroundColor;
        //    //    _subtitleTextBox.ForeColor = Color.White;
        //    //_subtitleTextBox.Dock = DockStyle.Fill;
        //    //    SetSubtitleFont();
        //    //    _subtitleTextBox.MouseClick += SubtitleTextBoxMouseClick;
        //    //    _subtitleTextBox.BringToFront();
        //    //_panelSubtitle.Controls.Add(_subtitleTextBox);
        //    //_panelSubtitle.BringToFront();
        //    //return _panelSubtitle;
        //}

        //public void SetSubtitleFont()
        //{
        //    var gs = Configuration.Settings.General;
        //    if (string.IsNullOrEmpty(gs.SubtitleFontName))
        //        gs.SubtitleFontName = "Tahoma";
        //    if (gs.VideoPlayerPreviewFontBold)
        //    {
        //        _subtitleTextBox.Font = new Font(gs.SubtitleFontName, gs.VideoPlayerPreviewFontSize * FontSizeFactor, FontStyle.Bold);
        //    }
        //    else
        //    {
        //        _subtitleTextBox.Font = new Font(gs.SubtitleFontName, gs.VideoPlayerPreviewFontSize * FontSizeFactor, FontStyle.Regular);
        //    }
        //    SubtitleText = _subtitleText;
        //}

        public void SetSubtitleFontUpper()
        {
            var gs = Configuration.Settings.General;
            if (string.IsNullOrEmpty(gs.SubtitleFontName))
                gs.SubtitleFontName = "Tahoma";
            if (gs.VideoPlayerPreviewFontBold)
            {
                _subtitleTextBoxUpper.Font = new Font(gs.SubtitleFontName, gs.VideoPlayerPreviewFontSize * FontSizeFactor, FontStyle.Bold);
            }
            else
            {
                _subtitleTextBoxUpper.Font = new Font(gs.SubtitleFontName, gs.VideoPlayerPreviewFontSize * FontSizeFactor, FontStyle.Regular);
            }
            SubtitleTextUpper = _subtitleTextUpper;
        }

        public void SetSubtitleFontUpperTop()
        {
            var gs = Configuration.Settings.General;
            if (string.IsNullOrEmpty(gs.SubtitleFontName))
                gs.SubtitleFontName = "Tahoma";
            if (gs.VideoPlayerPreviewFontBold)
            {
                _subtitleTextBoxUpperTop.Font = new Font(gs.SubtitleFontName, gs.VideoPlayerPreviewFontSize * FontSizeFactor, FontStyle.Bold);
            }
            else
            {
                _subtitleTextBoxUpperTop.Font = new Font(gs.SubtitleFontName, gs.VideoPlayerPreviewFontSize * FontSizeFactor, FontStyle.Regular);
            }
            SubtitleTextUpperTop = _subtitleTextUpperTop;
        }

        public void SetSubtitleFontUpperTopLeft()
        {
            var gs = Configuration.Settings.General;
            if (string.IsNullOrEmpty(gs.SubtitleFontName))
                gs.SubtitleFontName = "Tahoma";
            if (gs.VideoPlayerPreviewFontBold)
            {
                _subtitleTextBoxUpperTopLeft.Font = new Font(gs.SubtitleFontName, gs.VideoPlayerPreviewFontSize * FontSizeFactor, FontStyle.Bold);
            }
            else
            {
                _subtitleTextBoxUpperTopLeft.Font = new Font(gs.SubtitleFontName, gs.VideoPlayerPreviewFontSize * FontSizeFactor, FontStyle.Regular);
            }
            SubtitleTextUpperTopLeft = _subtitleTextUpperTopLeft;
        }

        public void SetSubtitleFontUpperTopRight()
        {
            var gs = Configuration.Settings.General;
            if (string.IsNullOrEmpty(gs.SubtitleFontName))
                gs.SubtitleFontName = "Tahoma";
            if (gs.VideoPlayerPreviewFontBold)
            {
                _subtitleTextBoxUpperTopRight.Font = new Font(gs.SubtitleFontName, gs.VideoPlayerPreviewFontSize * FontSizeFactor, FontStyle.Bold);
            }
            else
            {
                _subtitleTextBoxUpperTopRight.Font = new Font(gs.SubtitleFontName, gs.VideoPlayerPreviewFontSize * FontSizeFactor, FontStyle.Regular);
            }
            SubtitleTextUpperTopRight = _subtitleTextUpperTopRight;
        }

        public void SetSubtitleFontUpperCenter()
        {
            var gs = Configuration.Settings.General;
            if (string.IsNullOrEmpty(gs.SubtitleFontName))
                gs.SubtitleFontName = "Tahoma";
            if (gs.VideoPlayerPreviewFontBold)
            {
                _subtitleTextBoxUpperCenter.Font = new Font(gs.SubtitleFontName, gs.VideoPlayerPreviewFontSize * FontSizeFactor, FontStyle.Bold);
            }
            else
            {
                _subtitleTextBoxUpperCenter.Font = new Font(gs.SubtitleFontName, gs.VideoPlayerPreviewFontSize * FontSizeFactor, FontStyle.Regular);
            }
            SubtitleTextUpperCenter = _subtitleTextUpperCenter;
        }

        public void SetSubtitleFontBottomLeft()
        {
            var gs = Configuration.Settings.General;
            if (string.IsNullOrEmpty(gs.SubtitleFontName))
                gs.SubtitleFontName = "Tahoma";
            if (gs.VideoPlayerPreviewFontBold)
            {
                _subtitleTextBoxBottomLeft.Font = new Font(gs.SubtitleFontName, gs.VideoPlayerPreviewFontSize * FontSizeFactor, FontStyle.Bold);
            }
            else
            {
                _subtitleTextBoxBottomLeft.Font = new Font(gs.SubtitleFontName, gs.VideoPlayerPreviewFontSize * FontSizeFactor, FontStyle.Regular);
            }
            SubtitleTextBottomLeft = _subtitleTextBottomLeft;
        }

        public void SetSubtitleFontBottomRight()
        {
            var gs = Configuration.Settings.General;
            if (string.IsNullOrEmpty(gs.SubtitleFontName))
                gs.SubtitleFontName = "Tahoma";
            if (gs.VideoPlayerPreviewFontBold)
            {
                _subtitleTextBoxBottomRight.Font = new Font(gs.SubtitleFontName, gs.VideoPlayerPreviewFontSize * FontSizeFactor, FontStyle.Bold);
            }
            else
            {
                _subtitleTextBoxBottomRight.Font = new Font(gs.SubtitleFontName, gs.VideoPlayerPreviewFontSize * FontSizeFactor, FontStyle.Regular);
            }
            SubtitleTextBottomRight = _subtitleTextBottomRight;
        }

        //private void SubtitleTextBoxMouseClick(object sender, MouseEventArgs e)
        //{
        //    TogglePlayPause();
        //}

        private void SubtitleTextBoxUpperMouseClick(object sender, MouseEventArgs e)
        {
            TogglePlayPauseUpper();
        }

        private void SubtitleTextBoxUpperTopMouseClick(object sender, MouseEventArgs e)
        {
            TogglePlayPauseUpper();
        }

        private void SubtitleTextBoxUpperTopLeftMouseClick(object sender, MouseEventArgs e)
        {
            TogglePlayPauseUpper();
        }

        private void SubtitleTextBoxUpperTopRightMouseClick(object sender, MouseEventArgs e)
        {
            TogglePlayPauseUpper();
        }

        private void SubtitleTextBoxUpperCenterMouseClick(object sender, MouseEventArgs e)
        {
            TogglePlayPauseUpper();
        }

        private void SubtitleTextBoxBottomLeftMouseClick(object sender, MouseEventArgs e)
        {
            TogglePlayPauseUpper();
        }

        private void SubtitleTextBoxBottomRightMouseClick(object sender, MouseEventArgs e)
        {
            TogglePlayPauseUpper();
        }

        private static string RemoveSubStationAlphaFormatting(string s)
        {
            int indexOfBegin = s.IndexOf('{');
            while (indexOfBegin >= 0 && s.IndexOf('}') > indexOfBegin)
            {
                int indexOfEnd = s.IndexOf('}');
                s = s.Remove(indexOfBegin, (indexOfEnd - indexOfBegin) + 1);
                indexOfBegin = s.IndexOf('{', indexOfBegin);
            }
            return s;
        }

        public Paragraph LastParagraph { get; private set; }

        //public void SetSubtitleText(string text, Paragraph p)
        //{
        //    SubtitleText = text;
        //    LastParagraph = p;
        //}

        public void SetSubtitleTextUpper(string textUpper, Paragraph pUpper)
        {
            SubtitleTextUpper = textUpper;
            LastParagraph = pUpper;
        }

        public void SetSubtitleTextUpperTop(string text, Paragraph p)
        {
            SubtitleTextUpperTop = text;
            LastParagraph = p;
        }

        public void SetSubtitleTextUpperTopLeft(string textTopLeft, Paragraph pTopLeft)
        {
            SubtitleTextUpperTopLeft = textTopLeft;
            LastParagraph = pTopLeft;
        }

        public void SetSubtitleTextUpperTopRight(string textTopRight, Paragraph pTopRight)
        {
            SubtitleTextUpperTopRight = textTopRight;
            LastParagraph = pTopRight;
        }

        public void SetSubtitleTextUpperCenter(string textCenter, Paragraph pCenter)
        {
            SubtitleTextUpperCenter = textCenter;
            LastParagraph = pCenter;
        }

        public void SetSubtitleTextBottomLeft(string textButtomLeft, Paragraph pButtomLeft)
        {
            SubtitleTextBottomLeft = textButtomLeft;
            LastParagraph = pButtomLeft;
        }

        public void SetSubtitleTextBottomRight(string textButtomRight, Paragraph pButtomRight)
        {
            SubtitleTextBottomRight = textButtomRight;
            LastParagraph = pButtomRight;
        }

        //public string SubtitleText
        //{
        //    get
        //    {
        //        return _subtitleText;
        //    }
        //    set
        //    {
        //        _subtitleText = value;

        //        bool alignLeft = _subtitleText.StartsWith("{\\a1}", StringComparison.Ordinal) || _subtitleText.StartsWith("{\\an1}", StringComparison.Ordinal);
        //        //, StringComparison.Ordinal) || _subtitleText.StartsWith("{\\a5}", StringComparison.Ordinal) || _subtitleText.StartsWith("{\\a9}", StringComparison.Ordinal) || // sub station alpha
        //        // _subtitleText.StartsWith("{\\an1}", StringComparison.Ordinal) || _subtitleText.StartsWith("{\\an4}", StringComparison.Ordinal) || _subtitleText.StartsWith("{\\an7}", StringComparison.Ordinal); // advanced sub station alpha

        //        bool alignRight = _subtitleText.StartsWith("{\\a3}", StringComparison.Ordinal) || _subtitleText.StartsWith("{\\an3}", StringComparison.Ordinal);
        //        //, StringComparison.Ordinal) || _subtitleText.StartsWith("{\\a7}", StringComparison.Ordinal) || _subtitleText.StartsWith("{\\a11}", StringComparison.Ordinal) || // sub station alpha
        //        //                  _subtitleText.StartsWith("{\\an3}", StringComparison.Ordinal) || _subtitleText.StartsWith("{\\an6}", StringComparison.Ordinal) || _subtitleText.StartsWith("{\\an9}", StringComparison.Ordinal); // advanced sub station alpha

        //        // remove styles for display text (except italic)
        //        string text = RemoveSubStationAlphaFormatting(_subtitleText);
        //        text = HtmlUtil.RemoveOpenCloseTags(text, HtmlUtil.TagBold, HtmlUtil.TagUnderline);
        //        text = text.Replace("<i></i>", string.Empty);

        //        // display italic
        //        var sb = new StringBuilder();
        //        int i = 0;
        //        bool isItalic = false;
        //        bool isFontColor = false;
        //        int italicBegin = 0;
        //        int fontColorBegin = 0;
        //        _subtitleTextBox.Text = string.Empty;
        //        int letterCount = 0;
        //        var italicLookups = new System.Collections.Generic.Dictionary<int, int>();
        //        var fontColorLookups = new System.Collections.Generic.Dictionary<Point, Color>();
        //        Color fontColor = Color.White;
        //        while (i < text.Length)
        //        {
        //            if (text.Substring(i).StartsWith("<i>", StringComparison.OrdinalIgnoreCase))
        //            {
        //                _subtitleTextBox.AppendText(sb.ToString());
        //                sb = new StringBuilder();
        //                isItalic = true;
        //                italicBegin = letterCount;
        //                i += 2;
        //            }
        //            else if (text.Substring(i).StartsWith("</i>", StringComparison.OrdinalIgnoreCase) && isItalic)
        //            {
        //                italicLookups.Add(italicBegin, _subtitleTextBox.Text.Length + sb.ToString().Length - italicBegin);
        //                _subtitleTextBox.AppendText(sb.ToString());
        //                sb = new StringBuilder();
        //                isItalic = false;
        //                i += 3;
        //            }
        //            else if (text.Substring(i).StartsWith("<font ", StringComparison.OrdinalIgnoreCase))
        //            {
        //                string s = text.Substring(i);
        //                bool fontFound = false;
        //                int end = s.IndexOf('>');
        //                if (end > 0)
        //                {
        //                    string f = s.Substring(0, end);
        //                    int colorStart = f.IndexOf(" color=", StringComparison.Ordinal);

        //                    if (colorStart > 0)
        //                    {
        //                        int colorEnd = colorStart + " color=".Length + 1;
        //                        if (colorEnd < f.Length)
        //                        {
        //                            colorEnd = f.IndexOf('"', colorEnd);
        //                            if (colorEnd > 0 || colorEnd == -1)
        //                            {
        //                                if (colorEnd == -1)
        //                                    s = f.Substring(colorStart);
        //                                else
        //                                    s = f.Substring(colorStart, colorEnd - colorStart);
        //                                s = s.Remove(0, " color=".Length);
        //                                s = s.Trim('"');
        //                                s = s.Trim('\'');
        //                                try
        //                                {
        //                                    fontColor = ColorTranslator.FromHtml(s);
        //                                    fontFound = true;
        //                                }
        //                                catch
        //                                {
        //                                    fontFound = false;
        //                                    if (s.Length > 0)
        //                                    {
        //                                        try
        //                                        {
        //                                            fontColor = ColorTranslator.FromHtml("#" + s);
        //                                            fontFound = true;
        //                                        }
        //                                        catch
        //                                        {
        //                                            fontFound = false;
        //                                        }
        //                                    }
        //                                }
        //                            }
        //                        }
        //                    }
        //                    i += end;
        //                }
        //                if (fontFound)
        //                {
        //                    _subtitleTextBox.AppendText(sb.ToString());
        //                    sb = new StringBuilder();
        //                    isFontColor = true;
        //                    fontColorBegin = letterCount;
        //                }
        //            }
        //            else if (text.Substring(i).StartsWith("</font>", StringComparison.OrdinalIgnoreCase) && isFontColor)
        //            {
        //                fontColorLookups.Add(new Point(fontColorBegin, _subtitleTextBox.Text.Length + sb.ToString().Length - fontColorBegin), fontColor);
        //                _subtitleTextBox.AppendText(sb.ToString());
        //                sb = new StringBuilder();
        //                isFontColor = false;
        //                i += 6;
        //            }
        //            else if (text[i] == '\n') // RichTextBox only count NewLine as one character!
        //            {
        //                sb.Append(text[i]);
        //            }
        //            else
        //            {
        //                sb.Append(text[i]);
        //                letterCount++;
        //            }
        //            i++;
        //        }
        //        _subtitleTextBox.Text += sb.ToString();
        //        _subtitleTextBox.SelectAll();

        //        if (alignLeft)
        //            _subtitleTextBox.SelectionAlignment = HorizontalAlignment.Left;
        //        else if (alignRight)
        //            _subtitleTextBox.SelectionAlignment = HorizontalAlignment.Right;
        //        else
        //            _subtitleTextBox.SelectionAlignment = HorizontalAlignment.Center;

        //        _subtitleTextBox.DeselectAll();
        //        foreach (var entry in italicLookups)
        //        {
        //            Font currentFont = _subtitleTextBox.SelectionFont;
        //            FontStyle newFontStyle = FontStyle.Italic | FontStyle.Bold;
        //            if (!Configuration.Settings.General.VideoPlayerPreviewFontBold)
        //                newFontStyle = FontStyle.Italic;
        //            _subtitleTextBox.SelectionStart = entry.Key;
        //            _subtitleTextBox.SelectionLength = entry.Value;
        //            _subtitleTextBox.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
        //            _subtitleTextBox.DeselectAll();
        //        }
        //        foreach (var entry in fontColorLookups)
        //        {
        //            _subtitleTextBox.SelectionStart = entry.Key.X;
        //            _subtitleTextBox.SelectionLength = entry.Key.Y;
        //            _subtitleTextBox.SelectionColor = entry.Value;
        //            _subtitleTextBox.DeselectAll();
        //        }
        //    }
        //}

        public string SubtitleTextUpper
        {
            get
            {
                return _subtitleTextUpper;
            }
            set
            {
                _subtitleTextUpper = value;

                bool BottomLeft = _subtitleTextUpper.StartsWith("{\\a1}", StringComparison.Ordinal) || _subtitleTextUpper.StartsWith("{\\an1}", StringComparison.Ordinal);

                bool BottomCenter = _subtitleTextUpper.StartsWith("{\\a2}", StringComparison.Ordinal) || _subtitleTextUpper.StartsWith("{\\an2}", StringComparison.Ordinal);

                bool BottomRight = _subtitleTextUpper.StartsWith("{\\a3}", StringComparison.Ordinal) || _subtitleTextUpper.StartsWith("{\\an3}", StringComparison.Ordinal);

                //bool MiddleLeft = _subtitleTextUpper.StartsWith("{\\a4}", StringComparison.Ordinal) || _subtitleTextUpper.StartsWith("{\\an4}", StringComparison.Ordinal);

                bool MiddleCenter = _subtitleTextUpper.StartsWith("{\\a5}", StringComparison.Ordinal) || _subtitleTextUpper.StartsWith("{\\an5}", StringComparison.Ordinal);

                //bool MiddleRight = _subtitleTextUpper.StartsWith("{\\a6}", StringComparison.Ordinal) || _subtitleTextUpper.StartsWith("{\\an6}", StringComparison.Ordinal);

                bool TopLeft = _subtitleTextUpper.StartsWith("{\\a7}", StringComparison.Ordinal) || _subtitleTextUpper.StartsWith("{\\an7}", StringComparison.Ordinal);

                bool TopCenter = _subtitleTextUpper.StartsWith("{\\a8}", StringComparison.Ordinal) || _subtitleTextUpper.StartsWith("{\\an8}", StringComparison.Ordinal);

                bool TopRight = _subtitleTextUpper.StartsWith("{\\a9}", StringComparison.Ordinal) || _subtitleTextUpper.StartsWith("{\\an9}", StringComparison.Ordinal);

                string text = RemoveSubStationAlphaFormatting(_subtitleTextUpper);
                // Test with IndexOf method.
                if (text.IndexOf("\t") != -1)
                {
                    text = text.Substring(text.IndexOf("\t"));
                    text = HtmlUtil.RemoveOpenCloseTags(text, HtmlUtil.TagBold, HtmlUtil.TagUnderline);
                    text = text.Replace("<i></i>", string.Empty);
                    //_panelSubtitleUpper.Visible = true;
                    if (text == null || text == "")
                    {
                        _subtitleTextBoxUpper.Visible = false;
                    }
                    else
                    {
                        _subtitleTextBoxUpper.Visible = true;
                    }
                }
                else
                {
                    text = HtmlUtil.RemoveOpenCloseTags(text, HtmlUtil.TagBold, HtmlUtil.TagUnderline);
                    text = text.Replace("<i></i>", string.Empty);
                    // _panelSubtitleUpper.Visible = true;
                    if (text == null || text == "")
                    {
                        _subtitleTextBoxUpper.Visible = false;
                    }
                    else
                    {
                        _subtitleTextBoxUpper.Visible = true;
                    }
                }

                // display italic
                var sb = new StringBuilder();
                int i = 0;
                bool isItalic = false;
                bool isFontColor = false;
                int italicBegin = 0;
                int fontColorBegin = 0;
                _subtitleTextBoxUpper.Text = string.Empty;
                int letterCount = 0;
                var italicLookups = new System.Collections.Generic.Dictionary<int, int>();
                var fontColorLookups = new System.Collections.Generic.Dictionary<Point, Color>();
                Color fontColor = Color.White;
                while (i < text.Length)
                {
                    if (text.Substring(i).StartsWith("<i>", StringComparison.OrdinalIgnoreCase))
                    {
                        _subtitleTextBoxUpper.AppendText(sb.ToString());
                        sb = new StringBuilder();
                        isItalic = true;
                        italicBegin = letterCount;
                        i += 2;
                    }
                    else if (text.Substring(i).StartsWith("</i>", StringComparison.OrdinalIgnoreCase) && isItalic)
                    {
                        italicLookups.Add(italicBegin, _subtitleTextBoxUpper.Text.Length + sb.ToString().Length - italicBegin);
                        _subtitleTextBoxUpper.AppendText(sb.ToString());
                        sb = new StringBuilder();
                        isItalic = false;
                        i += 3;
                    }
                    else if (text.Substring(i).StartsWith("<font ", StringComparison.OrdinalIgnoreCase))
                    {
                        string s = text.Substring(i);
                        bool fontFound = false;
                        int end = s.IndexOf('>');
                        if (end > 0)
                        {
                            string f = s.Substring(0, end);
                            int colorStart = f.IndexOf(" color=", StringComparison.Ordinal);

                            if (colorStart > 0)
                            {
                                int colorEnd = colorStart + " color=".Length + 1;
                                if (colorEnd < f.Length)
                                {
                                    colorEnd = f.IndexOf('"', colorEnd);
                                    if (colorEnd > 0 || colorEnd == -1)
                                    {
                                        if (colorEnd == -1)
                                            s = f.Substring(colorStart);
                                        else
                                            s = f.Substring(colorStart, colorEnd - colorStart);
                                        s = s.Remove(0, " color=".Length);
                                        s = s.Trim('"');
                                        s = s.Trim('\'');
                                        try
                                        {
                                            fontColor = ColorTranslator.FromHtml(s);
                                            fontFound = true;
                                        }
                                        catch
                                        {
                                            fontFound = false;
                                            if (s.Length > 0)
                                            {
                                                try
                                                {
                                                    fontColor = ColorTranslator.FromHtml("#" + s);
                                                    fontFound = true;
                                                }
                                                catch
                                                {
                                                    fontFound = false;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            i += end;
                        }
                        if (fontFound)
                        {
                            _subtitleTextBoxUpper.AppendText(sb.ToString());
                            sb = new StringBuilder();
                            isFontColor = true;
                            fontColorBegin = letterCount;
                        }
                    }
                    else if (text.Substring(i).StartsWith("</font>", StringComparison.OrdinalIgnoreCase) && isFontColor)
                    {
                        fontColorLookups.Add(new Point(fontColorBegin, _subtitleTextBoxUpper.Text.Length + sb.ToString().Length - fontColorBegin), fontColor);
                        _subtitleTextBoxUpper.AppendText(sb.ToString());
                        sb = new StringBuilder();
                        isFontColor = false;
                        i += 6;
                    }
                    else if (text[i] == '\n') // RichTextBox only count NewLine as one character!
                    {
                        sb.Append(text[i]);
                    }
                    else
                    {
                        sb.Append(text[i]);
                        letterCount++;
                    }
                    i++;
                }
                _subtitleTextBoxUpper.Text += sb.ToString();
                _subtitleTextBoxUpper.SelectAll();

                if (BottomLeft)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = true;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (BottomCenter)
                {
                    _subtitleTextBoxUpper.Visible = true;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (BottomRight)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = true;
                }
                else if (MiddleCenter)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = true;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (TopLeft)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = true;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (TopCenter)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = true;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (TopRight)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = true;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }

                    _subtitleTextBoxUpper.DeselectAll();
                    foreach (var entry in italicLookups)
                    {
                        Font currentFont = _subtitleTextBoxUpper.SelectionFont;
                        FontStyle newFontStyle = FontStyle.Italic | FontStyle.Bold;
                        if (!Configuration.Settings.General.VideoPlayerPreviewFontBold)
                            newFontStyle = FontStyle.Italic;
                        _subtitleTextBoxUpper.SelectionStart = entry.Key;
                        _subtitleTextBoxUpper.SelectionLength = entry.Value;
                        _subtitleTextBoxUpper.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                        _subtitleTextBoxUpper.DeselectAll();
                    }
                    foreach (var entry in fontColorLookups)
                    {
                        _subtitleTextBoxUpper.SelectionStart = entry.Key.X;
                        _subtitleTextBoxUpper.SelectionLength = entry.Key.Y;
                        _subtitleTextBoxUpper.SelectionColor = entry.Value;
                        _subtitleTextBoxUpper.DeselectAll();
                    }
            }
        }

        public string SubtitleTextUpperTop
        {
            get
            {
                return _subtitleTextUpperTop;
            }
            set
            {
                _subtitleTextUpperTop = value;

                  bool BottomLeft = _subtitleTextUpperTop.StartsWith("{\\a1}", StringComparison.Ordinal) || _subtitleTextUpperTop.StartsWith("{\\an1}", StringComparison.Ordinal);

                    bool BottomCenter = _subtitleTextUpperTop.StartsWith("{\\a2}", StringComparison.Ordinal) || _subtitleTextUpperTop.StartsWith("{\\an2}", StringComparison.Ordinal);

                    bool BottomRight = _subtitleTextUpperTop.StartsWith("{\\a3}", StringComparison.Ordinal) || _subtitleTextUpperTop.StartsWith("{\\an3}", StringComparison.Ordinal);

                    //bool MiddleLeft = _subtitleTextUpperTop.StartsWith("{\\a4}", StringComparison.Ordinal) || _subtitleTextUpperTop.StartsWith("{\\an4}", StringComparison.Ordinal);

                    bool MiddleCenter = _subtitleTextUpperTop.StartsWith("{\\a5}", StringComparison.Ordinal) || _subtitleTextUpperTop.StartsWith("{\\an5}", StringComparison.Ordinal);

                    //bool MiddleRight = _subtitleTextUpperTop.StartsWith("{\\a6}", StringComparison.Ordinal) || _subtitleTextUpperTop.StartsWith("{\\an6}", StringComparison.Ordinal);

                    bool TopLeft = _subtitleTextUpperTop.StartsWith("{\\a7}", StringComparison.Ordinal) || _subtitleTextUpperTop.StartsWith("{\\an7}", StringComparison.Ordinal);

                    bool TopCenter = _subtitleTextUpperTop.StartsWith("{\\a8}", StringComparison.Ordinal) || _subtitleTextUpperTop.StartsWith("{\\an8}", StringComparison.Ordinal);

                    bool TopRight = _subtitleTextUpperTop.StartsWith("{\\a9}", StringComparison.Ordinal) || _subtitleTextUpperTop.StartsWith("{\\an9}", StringComparison.Ordinal);

                    string text = RemoveSubStationAlphaFormatting(_subtitleTextUpperTop);
                    // Test with IndexOf method.
                    if (text.IndexOf("\t") != -1)
                    {
                        text = text.Substring(text.IndexOf("\t"));
                        text = HtmlUtil.RemoveOpenCloseTags(text, HtmlUtil.TagBold, HtmlUtil.TagUnderline);
                        text = text.Replace("<i></i>", string.Empty);
                        //_panelSubtitleUpper.Visible = true;
                        if (text == null || text == "")
                        {
                            _subtitleTextBoxUpperTop.Visible = false;
                        }
                        else
                        {
                            _subtitleTextBoxUpperTop.Visible = true;
                        }
                    }
                    else
                    {
                        text = HtmlUtil.RemoveOpenCloseTags(text, HtmlUtil.TagBold, HtmlUtil.TagUnderline);
                        text = text.Replace("<i></i>", string.Empty);
                        // _panelSubtitleUpper.Visible = true;
                        if (text == null || text == "")
                        {
                            _subtitleTextBoxUpperTop.Visible = false;
                        }
                        else
                        {
                            _subtitleTextBoxUpperTop.Visible = true;
                        }
                    }

                    // display italic
                    var sb = new StringBuilder();
                    int i = 0;
                    bool isItalic = false;
                    bool isFontColor = false;
                    int italicBegin = 0;
                    int fontColorBegin = 0;
                    _subtitleTextBoxUpperTop.Text = string.Empty;
                    int letterCount = 0;
                    var italicLookups = new System.Collections.Generic.Dictionary<int, int>();
                    var fontColorLookups = new System.Collections.Generic.Dictionary<Point, Color>();
                    Color fontColor = Color.White;
                    while (i < text.Length)
                    {
                        if (text.Substring(i).StartsWith("<i>", StringComparison.OrdinalIgnoreCase))
                        {
                            _subtitleTextBoxUpperTop.AppendText(sb.ToString());
                            sb = new StringBuilder();
                            isItalic = true;
                            italicBegin = letterCount;
                            i += 2;
                        }
                        else if (text.Substring(i).StartsWith("</i>", StringComparison.OrdinalIgnoreCase) && isItalic)
                        {
                            italicLookups.Add(italicBegin, _subtitleTextBoxUpperTop.Text.Length + sb.ToString().Length - italicBegin);
                            _subtitleTextBoxUpperTop.AppendText(sb.ToString());
                            sb = new StringBuilder();
                            isItalic = false;
                            i += 3;
                        }
                        else if (text.Substring(i).StartsWith("<font ", StringComparison.OrdinalIgnoreCase))
                        {
                            string s = text.Substring(i);
                            bool fontFound = false;
                            int end = s.IndexOf('>');
                            if (end > 0)
                            {
                                string f = s.Substring(0, end);
                                int colorStart = f.IndexOf(" color=", StringComparison.Ordinal);

                                if (colorStart > 0)
                                {
                                    int colorEnd = colorStart + " color=".Length + 1;
                                    if (colorEnd < f.Length)
                                    {
                                        colorEnd = f.IndexOf('"', colorEnd);
                                        if (colorEnd > 0 || colorEnd == -1)
                                        {
                                            if (colorEnd == -1)
                                                s = f.Substring(colorStart);
                                            else
                                                s = f.Substring(colorStart, colorEnd - colorStart);
                                            s = s.Remove(0, " color=".Length);
                                            s = s.Trim('"');
                                            s = s.Trim('\'');
                                            try
                                            {
                                                fontColor = ColorTranslator.FromHtml(s);
                                                fontFound = true;
                                            }
                                            catch
                                            {
                                                fontFound = false;
                                                if (s.Length > 0)
                                                {
                                                    try
                                                    {
                                                        fontColor = ColorTranslator.FromHtml("#" + s);
                                                        fontFound = true;
                                                    }
                                                    catch
                                                    {
                                                        fontFound = false;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                i += end;
                            }
                            if (fontFound)
                            {
                                _subtitleTextBoxUpperTop.AppendText(sb.ToString());
                                sb = new StringBuilder();
                                isFontColor = true;
                                fontColorBegin = letterCount;
                            }
                        }
                        else if (text.Substring(i).StartsWith("</font>", StringComparison.OrdinalIgnoreCase) && isFontColor)
                        {
                            fontColorLookups.Add(new Point(fontColorBegin, _subtitleTextBoxUpperTop.Text.Length + sb.ToString().Length - fontColorBegin), fontColor);
                            _subtitleTextBoxUpperTop.AppendText(sb.ToString());
                            sb = new StringBuilder();
                            isFontColor = false;
                            i += 6;
                        }
                        else if (text[i] == '\n') // RichTextBox only count NewLine as one character!
                        {
                            sb.Append(text[i]);
                        }
                        else
                        {
                            sb.Append(text[i]);
                            letterCount++;
                        }
                        i++;
                    }
                    _subtitleTextBoxUpperTop.Text += sb.ToString();
                    _subtitleTextBoxUpperTop.SelectAll();

                if (BottomLeft)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = true;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (BottomCenter)
                {
                    _subtitleTextBoxUpper.Visible = true;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (BottomRight)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = true;
                }
                else if (MiddleCenter)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = true;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (TopLeft)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = true;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (TopCenter)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = true;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (TopRight)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = true;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else
                {
                    _subtitleTextBoxUpperTop.Visible = false;
                }

                _subtitleTextBoxUpperTop.DeselectAll();
                    foreach (var entry in italicLookups)
                    {
                        Font currentFont = _subtitleTextBoxUpperTop.SelectionFont;
                        FontStyle newFontStyle = FontStyle.Italic | FontStyle.Bold;
                        if (!Configuration.Settings.General.VideoPlayerPreviewFontBold)
                            newFontStyle = FontStyle.Italic;
                        _subtitleTextBoxUpperTop.SelectionStart = entry.Key;
                        _subtitleTextBoxUpperTop.SelectionLength = entry.Value;
                        _subtitleTextBoxUpperTop.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                        _subtitleTextBoxUpperTop.DeselectAll();
                    }
                    foreach (var entry in fontColorLookups)
                    {
                        _subtitleTextBoxUpperTop.SelectionStart = entry.Key.X;
                        _subtitleTextBoxUpperTop.SelectionLength = entry.Key.Y;
                        _subtitleTextBoxUpperTop.SelectionColor = entry.Value;
                        _subtitleTextBoxUpperTop.DeselectAll();
                    }
              
            }
        }

        public string SubtitleTextUpperTopLeft
        {
            get
            {
                return _subtitleTextUpperTopLeft;
            }
            set
            {
                _subtitleTextUpperTopLeft = value;

                bool BottomLeft = _subtitleTextUpperTopLeft.StartsWith("{\\a1}", StringComparison.Ordinal) || _subtitleTextUpperTopLeft.StartsWith("{\\an1}", StringComparison.Ordinal);

                bool BottomCenter = _subtitleTextUpperTopLeft.StartsWith("{\\a2}", StringComparison.Ordinal) || _subtitleTextUpperTopLeft.StartsWith("{\\an2}", StringComparison.Ordinal);

                bool BottomRight = _subtitleTextUpperTopLeft.StartsWith("{\\a3}", StringComparison.Ordinal) || _subtitleTextUpperTopLeft.StartsWith("{\\an3}", StringComparison.Ordinal);

                //bool MiddleLeft = _subtitleTextUpperTopLeft.StartsWith("{\\a4}", StringComparison.Ordinal) || _subtitleTextUpperTopLeft.StartsWith("{\\an4}", StringComparison.Ordinal);

                bool MiddleCenter = _subtitleTextUpperTopLeft.StartsWith("{\\a5}", StringComparison.Ordinal) || _subtitleTextUpperTopLeft.StartsWith("{\\an5}", StringComparison.Ordinal);

                //bool MiddleRight = _subtitleTextUpperTopLeft.StartsWith("{\\a6}", StringComparison.Ordinal) || _subtitleTextUpperTopLeft.StartsWith("{\\an6}", StringComparison.Ordinal);

                bool TopLeft = _subtitleTextUpperTopLeft.StartsWith("{\\a7}", StringComparison.Ordinal) || _subtitleTextUpperTopLeft.StartsWith("{\\an7}", StringComparison.Ordinal);

                bool TopCenter = _subtitleTextUpperTopLeft.StartsWith("{\\a8}", StringComparison.Ordinal) || _subtitleTextUpperTopLeft.StartsWith("{\\an8}", StringComparison.Ordinal);

                bool TopRight = _subtitleTextUpperTopLeft.StartsWith("{\\a9}", StringComparison.Ordinal) || _subtitleTextUpperTopLeft.StartsWith("{\\an9}", StringComparison.Ordinal);

                string text = RemoveSubStationAlphaFormatting(_subtitleTextUpperTopLeft);
                // Test with IndexOf method.
                if (text.IndexOf("\t") != -1)
                {
                    text = text.Substring(text.IndexOf("\t"));
                    text = HtmlUtil.RemoveOpenCloseTags(text, HtmlUtil.TagBold, HtmlUtil.TagUnderline);
                    text = text.Replace("<i></i>", string.Empty);
                    //_panelSubtitleUpper.Visible = true;
                    if (text == null || text == "")
                    {
                        _subtitleTextBoxUpperTopLeft.Visible = false;
                    }
                    else
                    {
                        _subtitleTextBoxUpperTopLeft.Visible = true;
                    }
                }
                else
                {
                    text = HtmlUtil.RemoveOpenCloseTags(text, HtmlUtil.TagBold, HtmlUtil.TagUnderline);
                    text = text.Replace("<i></i>", string.Empty);
                    // _panelSubtitleUpper.Visible = true;
                    if (text == null || text == "")
                    {
                        _subtitleTextBoxUpperTopLeft.Visible = false;
                    }
                    else
                    {
                        _subtitleTextBoxUpperTopLeft.Visible = true;
                    }
                }

                // display italic
                var sb = new StringBuilder();
                int i = 0;
                bool isItalic = false;
                bool isFontColor = false;
                int italicBegin = 0;
                int fontColorBegin = 0;
                _subtitleTextBoxUpperTopLeft.Text = string.Empty;
                int letterCount = 0;
                var italicLookups = new System.Collections.Generic.Dictionary<int, int>();
                var fontColorLookups = new System.Collections.Generic.Dictionary<Point, Color>();
                Color fontColor = Color.White;
                while (i < text.Length)
                {
                    if (text.Substring(i).StartsWith("<i>", StringComparison.OrdinalIgnoreCase))
                    {
                        _subtitleTextBoxUpperTopLeft.AppendText(sb.ToString());
                        sb = new StringBuilder();
                        isItalic = true;
                        italicBegin = letterCount;
                        i += 2;
                    }
                    else if (text.Substring(i).StartsWith("</i>", StringComparison.OrdinalIgnoreCase) && isItalic)
                    {
                        italicLookups.Add(italicBegin, _subtitleTextBoxUpperTopLeft.Text.Length + sb.ToString().Length - italicBegin);
                        _subtitleTextBoxUpperTopLeft.AppendText(sb.ToString());
                        sb = new StringBuilder();
                        isItalic = false;
                        i += 3;
                    }
                    else if (text.Substring(i).StartsWith("<font ", StringComparison.OrdinalIgnoreCase))
                    {
                        string s = text.Substring(i);
                        bool fontFound = false;
                        int end = s.IndexOf('>');
                        if (end > 0)
                        {
                            string f = s.Substring(0, end);
                            int colorStart = f.IndexOf(" color=", StringComparison.Ordinal);

                            if (colorStart > 0)
                            {
                                int colorEnd = colorStart + " color=".Length + 1;
                                if (colorEnd < f.Length)
                                {
                                    colorEnd = f.IndexOf('"', colorEnd);
                                    if (colorEnd > 0 || colorEnd == -1)
                                    {
                                        if (colorEnd == -1)
                                            s = f.Substring(colorStart);
                                        else
                                            s = f.Substring(colorStart, colorEnd - colorStart);
                                        s = s.Remove(0, " color=".Length);
                                        s = s.Trim('"');
                                        s = s.Trim('\'');
                                        try
                                        {
                                            fontColor = ColorTranslator.FromHtml(s);
                                            fontFound = true;
                                        }
                                        catch
                                        {
                                            fontFound = false;
                                            if (s.Length > 0)
                                            {
                                                try
                                                {
                                                    fontColor = ColorTranslator.FromHtml("#" + s);
                                                    fontFound = true;
                                                }
                                                catch
                                                {
                                                    fontFound = false;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            i += end;
                        }
                        if (fontFound)
                        {
                            _subtitleTextBoxUpperTopLeft.AppendText(sb.ToString());
                            sb = new StringBuilder();
                            isFontColor = true;
                            fontColorBegin = letterCount;
                        }
                    }
                    else if (text.Substring(i).StartsWith("</font>", StringComparison.OrdinalIgnoreCase) && isFontColor)
                    {
                        fontColorLookups.Add(new Point(fontColorBegin, _subtitleTextBoxUpperTopLeft.Text.Length + sb.ToString().Length - fontColorBegin), fontColor);
                        _subtitleTextBoxUpperTopLeft.AppendText(sb.ToString());
                        sb = new StringBuilder();
                        isFontColor = false;
                        i += 6;
                    }
                    else if (text[i] == '\n') // RichTextBox only count NewLine as one character!
                    {
                        sb.Append(text[i]);
                    }
                    else
                    {
                        sb.Append(text[i]);
                        letterCount++;
                    }
                    i++;
                }
                _subtitleTextBoxUpperTopLeft.Text += sb.ToString();
                _subtitleTextBoxUpperTopLeft.SelectAll();

                if (BottomLeft)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = true;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (BottomCenter)
                {
                    _subtitleTextBoxUpper.Visible = true;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (BottomRight)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = true;
                }
                else if (MiddleCenter)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = true;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (TopLeft)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = true;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (TopCenter)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = true;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (TopRight)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = true;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else
                {
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                }

                _subtitleTextBoxUpperTopLeft.DeselectAll();
                foreach (var entry in italicLookups)
                {
                    Font currentFont = _subtitleTextBoxUpperTopLeft.SelectionFont;
                    FontStyle newFontStyle = FontStyle.Italic | FontStyle.Bold;
                    if (!Configuration.Settings.General.VideoPlayerPreviewFontBold)
                        newFontStyle = FontStyle.Italic;
                    _subtitleTextBoxUpperTopLeft.SelectionStart = entry.Key;
                    _subtitleTextBoxUpperTopLeft.SelectionLength = entry.Value;
                    _subtitleTextBoxUpperTopLeft.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                    _subtitleTextBoxUpperTopLeft.DeselectAll();
                }
                foreach (var entry in fontColorLookups)
                {
                    _subtitleTextBoxUpperTopLeft.SelectionStart = entry.Key.X;
                    _subtitleTextBoxUpperTopLeft.SelectionLength = entry.Key.Y;
                    _subtitleTextBoxUpperTopLeft.SelectionColor = entry.Value;
                    _subtitleTextBoxUpperTopLeft.DeselectAll();
                }

            }
        }

        public string SubtitleTextUpperTopRight
        {
            get
            {
                return _subtitleTextUpperTopRight;
            }
            set
            {
                _subtitleTextUpperTopRight = value;

                bool BottomLeft = _subtitleTextUpperTopRight.StartsWith("{\\a1}", StringComparison.Ordinal) || _subtitleTextUpperTopRight.StartsWith("{\\an1}", StringComparison.Ordinal);

                bool BottomCenter = _subtitleTextUpperTopRight.StartsWith("{\\a2}", StringComparison.Ordinal) || _subtitleTextUpperTopRight.StartsWith("{\\an2}", StringComparison.Ordinal);

                bool BottomRight = _subtitleTextUpperTopRight.StartsWith("{\\a3}", StringComparison.Ordinal) || _subtitleTextUpperTopRight.StartsWith("{\\an3}", StringComparison.Ordinal);

                //bool MiddleLeft = _subtitleTextUpperTopRight.StartsWith("{\\a4}", StringComparison.Ordinal) || _subtitleTextUpperTopRight.StartsWith("{\\an4}", StringComparison.Ordinal);

                bool MiddleCenter = _subtitleTextUpperTopRight.StartsWith("{\\a5}", StringComparison.Ordinal) || _subtitleTextUpperTopRight.StartsWith("{\\an5}", StringComparison.Ordinal);

                //bool MiddleRight = _subtitleTextUpperTopRight.StartsWith("{\\a6}", StringComparison.Ordinal) || _subtitleTextUpperTopRight.StartsWith("{\\an6}", StringComparison.Ordinal);

                bool TopLeft = _subtitleTextUpperTopRight.StartsWith("{\\a7}", StringComparison.Ordinal) || _subtitleTextUpperTopRight.StartsWith("{\\an7}", StringComparison.Ordinal);

                bool TopCenter = _subtitleTextUpperTopRight.StartsWith("{\\a8}", StringComparison.Ordinal) || _subtitleTextUpperTopRight.StartsWith("{\\an8}", StringComparison.Ordinal);

                bool TopRight = _subtitleTextUpperTopRight.StartsWith("{\\a9}", StringComparison.Ordinal) || _subtitleTextUpperTopRight.StartsWith("{\\an9}", StringComparison.Ordinal);

                string text = RemoveSubStationAlphaFormatting(_subtitleTextUpperTopRight);
                // Test with IndexOf method.
                if (text.IndexOf("\t") != -1)
                {
                    text = text.Substring(text.IndexOf("\t"));
                    text = HtmlUtil.RemoveOpenCloseTags(text, HtmlUtil.TagBold, HtmlUtil.TagUnderline);
                    text = text.Replace("<i></i>", string.Empty);
                    //_panelSubtitleUpper.Visible = true;
                    if (text == null || text == "")
                    {
                        _subtitleTextBoxUpperTopRight.Visible = false;
                    }
                    else
                    {
                        _subtitleTextBoxUpperTopRight.Visible = true;
                    }
                }
                else
                {
                    text = HtmlUtil.RemoveOpenCloseTags(text, HtmlUtil.TagBold, HtmlUtil.TagUnderline);
                    text = text.Replace("<i></i>", string.Empty);
                    // _panelSubtitleUpper.Visible = true;
                    if (text == null || text == "")
                    {
                        _subtitleTextBoxUpperTopRight.Visible = false;
                    }
                    else
                    {
                        _subtitleTextBoxUpperTopRight.Visible = true;
                    }
                }

                // display italic
                var sb = new StringBuilder();
                int i = 0;
                bool isItalic = false;
                bool isFontColor = false;
                int italicBegin = 0;
                int fontColorBegin = 0;
                _subtitleTextBoxUpperTopRight.Text = string.Empty;
                int letterCount = 0;
                var italicLookups = new System.Collections.Generic.Dictionary<int, int>();
                var fontColorLookups = new System.Collections.Generic.Dictionary<Point, Color>();
                Color fontColor = Color.White;
                while (i < text.Length)
                {
                    if (text.Substring(i).StartsWith("<i>", StringComparison.OrdinalIgnoreCase))
                    {
                        _subtitleTextBoxUpperTopRight.AppendText(sb.ToString());
                        sb = new StringBuilder();
                        isItalic = true;
                        italicBegin = letterCount;
                        i += 2;
                    }
                    else if (text.Substring(i).StartsWith("</i>", StringComparison.OrdinalIgnoreCase) && isItalic)
                    {
                        italicLookups.Add(italicBegin, _subtitleTextBoxUpperTopRight.Text.Length + sb.ToString().Length - italicBegin);
                        _subtitleTextBoxUpperTopRight.AppendText(sb.ToString());
                        sb = new StringBuilder();
                        isItalic = false;
                        i += 3;
                    }
                    else if (text.Substring(i).StartsWith("<font ", StringComparison.OrdinalIgnoreCase))
                    {
                        string s = text.Substring(i);
                        bool fontFound = false;
                        int end = s.IndexOf('>');
                        if (end > 0)
                        {
                            string f = s.Substring(0, end);
                            int colorStart = f.IndexOf(" color=", StringComparison.Ordinal);

                            if (colorStart > 0)
                            {
                                int colorEnd = colorStart + " color=".Length + 1;
                                if (colorEnd < f.Length)
                                {
                                    colorEnd = f.IndexOf('"', colorEnd);
                                    if (colorEnd > 0 || colorEnd == -1)
                                    {
                                        if (colorEnd == -1)
                                            s = f.Substring(colorStart);
                                        else
                                            s = f.Substring(colorStart, colorEnd - colorStart);
                                        s = s.Remove(0, " color=".Length);
                                        s = s.Trim('"');
                                        s = s.Trim('\'');
                                        try
                                        {
                                            fontColor = ColorTranslator.FromHtml(s);
                                            fontFound = true;
                                        }
                                        catch
                                        {
                                            fontFound = false;
                                            if (s.Length > 0)
                                            {
                                                try
                                                {
                                                    fontColor = ColorTranslator.FromHtml("#" + s);
                                                    fontFound = true;
                                                }
                                                catch
                                                {
                                                    fontFound = false;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            i += end;
                        }
                        if (fontFound)
                        {
                            _subtitleTextBoxUpperTopRight.AppendText(sb.ToString());
                            sb = new StringBuilder();
                            isFontColor = true;
                            fontColorBegin = letterCount;
                        }
                    }
                    else if (text.Substring(i).StartsWith("</font>", StringComparison.OrdinalIgnoreCase) && isFontColor)
                    {
                        fontColorLookups.Add(new Point(fontColorBegin, _subtitleTextBoxUpperTopRight.Text.Length + sb.ToString().Length - fontColorBegin), fontColor);
                        _subtitleTextBoxUpperTopRight.AppendText(sb.ToString());
                        sb = new StringBuilder();
                        isFontColor = false;
                        i += 6;
                    }
                    else if (text[i] == '\n') // RichTextBox only count NewLine as one character!
                    {
                        sb.Append(text[i]);
                    }
                    else
                    {
                        sb.Append(text[i]);
                        letterCount++;
                    }
                    i++;
                }
                _subtitleTextBoxUpperTopRight.Text += sb.ToString();
                _subtitleTextBoxUpperTopRight.SelectAll();

                if (BottomLeft)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = true;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (BottomCenter)
                {
                    _subtitleTextBoxUpper.Visible = true;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (BottomRight)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = true;
                }
                else if (MiddleCenter)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = true;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (TopLeft)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = true;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (TopCenter)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = true;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (TopRight)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = true;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else
                {
                    _subtitleTextBoxUpperTopRight.Visible = false;
                }

                _subtitleTextBoxUpperTopRight.DeselectAll();
                foreach (var entry in italicLookups)
                {
                    Font currentFont = _subtitleTextBoxUpperTopRight.SelectionFont;
                    FontStyle newFontStyle = FontStyle.Italic | FontStyle.Bold;
                    if (!Configuration.Settings.General.VideoPlayerPreviewFontBold)
                        newFontStyle = FontStyle.Italic;
                    _subtitleTextBoxUpperTopRight.SelectionStart = entry.Key;
                    _subtitleTextBoxUpperTopRight.SelectionLength = entry.Value;
                    _subtitleTextBoxUpperTopRight.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                    _subtitleTextBoxUpperTopRight.DeselectAll();
                }
                foreach (var entry in fontColorLookups)
                {
                    _subtitleTextBoxUpperTopRight.SelectionStart = entry.Key.X;
                    _subtitleTextBoxUpperTopRight.SelectionLength = entry.Key.Y;
                    _subtitleTextBoxUpperTopRight.SelectionColor = entry.Value;
                    _subtitleTextBoxUpperTopRight.DeselectAll();
                }

            }
        }

        public string SubtitleTextUpperCenter
        {
            get
            {
                return _subtitleTextUpperCenter;
            }
            set
            {
                _subtitleTextUpperCenter = value;

                bool BottomLeft = _subtitleTextUpperCenter.StartsWith("{\\a1}", StringComparison.Ordinal) || _subtitleTextUpperCenter.StartsWith("{\\an1}", StringComparison.Ordinal);

                bool BottomCenter = _subtitleTextUpperCenter.StartsWith("{\\a2}", StringComparison.Ordinal) || _subtitleTextUpperCenter.StartsWith("{\\an2}", StringComparison.Ordinal);

                bool BottomRight = _subtitleTextUpperCenter.StartsWith("{\\a3}", StringComparison.Ordinal) || _subtitleTextUpperCenter.StartsWith("{\\an3}", StringComparison.Ordinal);

                //bool MiddleLeft = _subtitleTextUpperCenter.StartsWith("{\\a4}", StringComparison.Ordinal) || _subtitleTextUpperCenter.StartsWith("{\\an4}", StringComparison.Ordinal);

                bool MiddleCenter = _subtitleTextUpperCenter.StartsWith("{\\a5}", StringComparison.Ordinal) || _subtitleTextUpperCenter.StartsWith("{\\an5}", StringComparison.Ordinal);

                //bool MiddleRight = _subtitleTextUpperCenter.StartsWith("{\\a6}", StringComparison.Ordinal) || _subtitleTextUpperCenter.StartsWith("{\\an6}", StringComparison.Ordinal);

                bool TopLeft = _subtitleTextUpperCenter.StartsWith("{\\a7}", StringComparison.Ordinal) || _subtitleTextUpperCenter.StartsWith("{\\an7}", StringComparison.Ordinal);

                bool TopCenter = _subtitleTextUpperCenter.StartsWith("{\\a8}", StringComparison.Ordinal) || _subtitleTextUpperCenter.StartsWith("{\\an8}", StringComparison.Ordinal);

                bool TopRight = _subtitleTextUpperCenter.StartsWith("{\\a9}", StringComparison.Ordinal) || _subtitleTextUpperCenter.StartsWith("{\\an9}", StringComparison.Ordinal);

                string text = RemoveSubStationAlphaFormatting(_subtitleTextUpperCenter);
                // Test with IndexOf method.
                if (text.IndexOf("\t") != -1)
                {
                    text = text.Substring(text.IndexOf("\t"));
                    text = HtmlUtil.RemoveOpenCloseTags(text, HtmlUtil.TagBold, HtmlUtil.TagUnderline);
                    text = text.Replace("<i></i>", string.Empty);
                    //_panelSubtitleUpper.Visible = true;
                    if (text == null || text == "")
                    {
                        _subtitleTextBoxUpperCenter.Visible = false;
                    }
                    else
                    {
                        _subtitleTextBoxUpperCenter.Visible = true;
                    }
                }
                else
                {
                    text = HtmlUtil.RemoveOpenCloseTags(text, HtmlUtil.TagBold, HtmlUtil.TagUnderline);
                    text = text.Replace("<i></i>", string.Empty);
                    // _panelSubtitleUpper.Visible = true;
                    if (text == null || text == "")
                    {
                        _subtitleTextBoxUpperCenter.Visible = false;
                    }
                    else
                    {
                        _subtitleTextBoxUpperCenter.Visible = true;
                    }
                }

                // display italic
                var sb = new StringBuilder();
                int i = 0;
                bool isItalic = false;
                bool isFontColor = false;
                int italicBegin = 0;
                int fontColorBegin = 0;
                _subtitleTextBoxUpperCenter.Text = string.Empty;
                int letterCount = 0;
                var italicLookups = new System.Collections.Generic.Dictionary<int, int>();
                var fontColorLookups = new System.Collections.Generic.Dictionary<Point, Color>();
                Color fontColor = Color.White;
                while (i < text.Length)
                {
                    if (text.Substring(i).StartsWith("<i>", StringComparison.OrdinalIgnoreCase))
                    {
                        _subtitleTextBoxUpperCenter.AppendText(sb.ToString());
                        sb = new StringBuilder();
                        isItalic = true;
                        italicBegin = letterCount;
                        i += 2;
                    }
                    else if (text.Substring(i).StartsWith("</i>", StringComparison.OrdinalIgnoreCase) && isItalic)
                    {
                        italicLookups.Add(italicBegin, _subtitleTextBoxUpperCenter.Text.Length + sb.ToString().Length - italicBegin);
                        _subtitleTextBoxUpperCenter.AppendText(sb.ToString());
                        sb = new StringBuilder();
                        isItalic = false;
                        i += 3;
                    }
                    else if (text.Substring(i).StartsWith("<font ", StringComparison.OrdinalIgnoreCase))
                    {
                        string s = text.Substring(i);
                        bool fontFound = false;
                        int end = s.IndexOf('>');
                        if (end > 0)
                        {
                            string f = s.Substring(0, end);
                            int colorStart = f.IndexOf(" color=", StringComparison.Ordinal);

                            if (colorStart > 0)
                            {
                                int colorEnd = colorStart + " color=".Length + 1;
                                if (colorEnd < f.Length)
                                {
                                    colorEnd = f.IndexOf('"', colorEnd);
                                    if (colorEnd > 0 || colorEnd == -1)
                                    {
                                        if (colorEnd == -1)
                                            s = f.Substring(colorStart);
                                        else
                                            s = f.Substring(colorStart, colorEnd - colorStart);
                                        s = s.Remove(0, " color=".Length);
                                        s = s.Trim('"');
                                        s = s.Trim('\'');
                                        try
                                        {
                                            fontColor = ColorTranslator.FromHtml(s);
                                            fontFound = true;
                                        }
                                        catch
                                        {
                                            fontFound = false;
                                            if (s.Length > 0)
                                            {
                                                try
                                                {
                                                    fontColor = ColorTranslator.FromHtml("#" + s);
                                                    fontFound = true;
                                                }
                                                catch
                                                {
                                                    fontFound = false;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            i += end;
                        }
                        if (fontFound)
                        {
                            _subtitleTextBoxUpperCenter.AppendText(sb.ToString());
                            sb = new StringBuilder();
                            isFontColor = true;
                            fontColorBegin = letterCount;
                        }
                    }
                    else if (text.Substring(i).StartsWith("</font>", StringComparison.OrdinalIgnoreCase) && isFontColor)
                    {
                        fontColorLookups.Add(new Point(fontColorBegin, _subtitleTextBoxUpperCenter.Text.Length + sb.ToString().Length - fontColorBegin), fontColor);
                        _subtitleTextBoxUpperCenter.AppendText(sb.ToString());
                        sb = new StringBuilder();
                        isFontColor = false;
                        i += 6;
                    }
                    else if (text[i] == '\n') // RichTextBox only count NewLine as one character!
                    {
                        sb.Append(text[i]);
                    }
                    else
                    {
                        sb.Append(text[i]);
                        letterCount++;
                    }
                    i++;
                }
                _subtitleTextBoxUpperCenter.Text += sb.ToString();
                _subtitleTextBoxUpperCenter.SelectAll();

                if (BottomLeft)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = true;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (BottomCenter)
                {
                    _subtitleTextBoxUpper.Visible = true;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (BottomRight)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = true;
                }
                else if (MiddleCenter)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = true;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (TopLeft)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = true;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (TopCenter)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = true;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (TopRight)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = true;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else
                {
                    _subtitleTextBoxUpperCenter.Visible = false;
                }

                _subtitleTextBoxUpperCenter.DeselectAll();
                foreach (var entry in italicLookups)
                {
                    Font currentFont = _subtitleTextBoxUpperCenter.SelectionFont;
                    FontStyle newFontStyle = FontStyle.Italic | FontStyle.Bold;
                    if (!Configuration.Settings.General.VideoPlayerPreviewFontBold)
                        newFontStyle = FontStyle.Italic;
                    _subtitleTextBoxUpperCenter.SelectionStart = entry.Key;
                    _subtitleTextBoxUpperCenter.SelectionLength = entry.Value;
                    _subtitleTextBoxUpperCenter.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                    _subtitleTextBoxUpperCenter.DeselectAll();
                }
                foreach (var entry in fontColorLookups)
                {
                    _subtitleTextBoxUpperCenter.SelectionStart = entry.Key.X;
                    _subtitleTextBoxUpperCenter.SelectionLength = entry.Key.Y;
                    _subtitleTextBoxUpperCenter.SelectionColor = entry.Value;
                    _subtitleTextBoxUpperCenter.DeselectAll();
                }

            }
        }

        public string SubtitleTextBottomLeft
        {
            get
            {
                return _subtitleTextBottomLeft;
            }
            set
            {
                _subtitleTextBottomLeft = value;

                bool BottomLeft = _subtitleTextBottomLeft.StartsWith("{\\a1}", StringComparison.Ordinal) || _subtitleTextBottomLeft.StartsWith("{\\an1}", StringComparison.Ordinal);

                bool BottomCenter = _subtitleTextBottomLeft.StartsWith("{\\a2}", StringComparison.Ordinal) || _subtitleTextBottomLeft.StartsWith("{\\an2}", StringComparison.Ordinal);

                bool BottomRight = _subtitleTextBottomLeft.StartsWith("{\\a3}", StringComparison.Ordinal) || _subtitleTextBottomLeft.StartsWith("{\\an3}", StringComparison.Ordinal);

                //bool MiddleLeft = _subtitleTextBottomLeft.StartsWith("{\\a4}", StringComparison.Ordinal) || _subtitleTextBottomLeft.StartsWith("{\\an4}", StringComparison.Ordinal);

                bool MiddleCenter = _subtitleTextBottomLeft.StartsWith("{\\a5}", StringComparison.Ordinal) || _subtitleTextBottomLeft.StartsWith("{\\an5}", StringComparison.Ordinal);

                //bool MiddleRight = _subtitleTextBottomLeft.StartsWith("{\\a6}", StringComparison.Ordinal) || _subtitleTextBottomLeft.StartsWith("{\\an6}", StringComparison.Ordinal);

                bool TopLeft = _subtitleTextBottomLeft.StartsWith("{\\a7}", StringComparison.Ordinal) || _subtitleTextBottomLeft.StartsWith("{\\an7}", StringComparison.Ordinal);

                bool TopCenter = _subtitleTextBottomLeft.StartsWith("{\\a8}", StringComparison.Ordinal) || _subtitleTextBottomLeft.StartsWith("{\\an8}", StringComparison.Ordinal);

                bool TopRight = _subtitleTextBottomLeft.StartsWith("{\\a9}", StringComparison.Ordinal) || _subtitleTextBottomLeft.StartsWith("{\\an9}", StringComparison.Ordinal);

                string text = RemoveSubStationAlphaFormatting(_subtitleTextBottomLeft);
                // Test with IndexOf method.
                if (text.IndexOf("\t") != -1)
                {
                    text = text.Substring(text.IndexOf("\t"));
                    text = HtmlUtil.RemoveOpenCloseTags(text, HtmlUtil.TagBold, HtmlUtil.TagUnderline);
                    text = text.Replace("<i></i>", string.Empty);
                    //_panelSubtitleUpper.Visible = true;
                    if (text == null || text == "")
                    {
                        _subtitleTextBoxBottomLeft.Visible = false;
                    }
                    else
                    {
                        _subtitleTextBoxBottomLeft.Visible = true;
                    }
                }
                else
                {
                    text = HtmlUtil.RemoveOpenCloseTags(text, HtmlUtil.TagBold, HtmlUtil.TagUnderline);
                    text = text.Replace("<i></i>", string.Empty);
                    // _panelSubtitleUpper.Visible = true;
                    if (text == null || text == "")
                    {
                        _subtitleTextBoxBottomLeft.Visible = false;
                    }
                    else
                    {
                        _subtitleTextBoxBottomLeft.Visible = true;
                    }
                }

                // display italic
                var sb = new StringBuilder();
                int i = 0;
                bool isItalic = false;
                bool isFontColor = false;
                int italicBegin = 0;
                int fontColorBegin = 0;
                _subtitleTextBoxBottomLeft.Text = string.Empty;
                int letterCount = 0;
                var italicLookups = new System.Collections.Generic.Dictionary<int, int>();
                var fontColorLookups = new System.Collections.Generic.Dictionary<Point, Color>();
                Color fontColor = Color.White;
                while (i < text.Length)
                {
                    if (text.Substring(i).StartsWith("<i>", StringComparison.OrdinalIgnoreCase))
                    {
                        _subtitleTextBoxBottomLeft.AppendText(sb.ToString());
                        sb = new StringBuilder();
                        isItalic = true;
                        italicBegin = letterCount;
                        i += 2;
                    }
                    else if (text.Substring(i).StartsWith("</i>", StringComparison.OrdinalIgnoreCase) && isItalic)
                    {
                        italicLookups.Add(italicBegin, _subtitleTextBoxBottomLeft.Text.Length + sb.ToString().Length - italicBegin);
                        _subtitleTextBoxBottomLeft.AppendText(sb.ToString());
                        sb = new StringBuilder();
                        isItalic = false;
                        i += 3;
                    }
                    else if (text.Substring(i).StartsWith("<font ", StringComparison.OrdinalIgnoreCase))
                    {
                        string s = text.Substring(i);
                        bool fontFound = false;
                        int end = s.IndexOf('>');
                        if (end > 0)
                        {
                            string f = s.Substring(0, end);
                            int colorStart = f.IndexOf(" color=", StringComparison.Ordinal);

                            if (colorStart > 0)
                            {
                                int colorEnd = colorStart + " color=".Length + 1;
                                if (colorEnd < f.Length)
                                {
                                    colorEnd = f.IndexOf('"', colorEnd);
                                    if (colorEnd > 0 || colorEnd == -1)
                                    {
                                        if (colorEnd == -1)
                                            s = f.Substring(colorStart);
                                        else
                                            s = f.Substring(colorStart, colorEnd - colorStart);
                                        s = s.Remove(0, " color=".Length);
                                        s = s.Trim('"');
                                        s = s.Trim('\'');
                                        try
                                        {
                                            fontColor = ColorTranslator.FromHtml(s);
                                            fontFound = true;
                                        }
                                        catch
                                        {
                                            fontFound = false;
                                            if (s.Length > 0)
                                            {
                                                try
                                                {
                                                    fontColor = ColorTranslator.FromHtml("#" + s);
                                                    fontFound = true;
                                                }
                                                catch
                                                {
                                                    fontFound = false;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            i += end;
                        }
                        if (fontFound)
                        {
                            _subtitleTextBoxBottomLeft.AppendText(sb.ToString());
                            sb = new StringBuilder();
                            isFontColor = true;
                            fontColorBegin = letterCount;
                        }
                    }
                    else if (text.Substring(i).StartsWith("</font>", StringComparison.OrdinalIgnoreCase) && isFontColor)
                    {
                        fontColorLookups.Add(new Point(fontColorBegin, _subtitleTextBoxBottomLeft.Text.Length + sb.ToString().Length - fontColorBegin), fontColor);
                        _subtitleTextBoxBottomLeft.AppendText(sb.ToString());
                        sb = new StringBuilder();
                        isFontColor = false;
                        i += 6;
                    }
                    else if (text[i] == '\n') // RichTextBox only count NewLine as one character!
                    {
                        sb.Append(text[i]);
                    }
                    else
                    {
                        sb.Append(text[i]);
                        letterCount++;
                    }
                    i++;
                }
                _subtitleTextBoxBottomLeft.Text += sb.ToString();
                _subtitleTextBoxBottomLeft.SelectAll();

                if (BottomLeft)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = true;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (BottomCenter)
                {
                    _subtitleTextBoxUpper.Visible = true;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (BottomRight)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = true;
                }
                else if (MiddleCenter)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = true;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (TopLeft)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = true;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (TopCenter)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = true;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (TopRight)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = true;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else
                {
                    _subtitleTextBoxBottomLeft.Visible = false;
                }

                _subtitleTextBoxBottomLeft.DeselectAll();
                foreach (var entry in italicLookups)
                {
                    Font currentFont = _subtitleTextBoxBottomLeft.SelectionFont;
                    FontStyle newFontStyle = FontStyle.Italic | FontStyle.Bold;
                    if (!Configuration.Settings.General.VideoPlayerPreviewFontBold)
                        newFontStyle = FontStyle.Italic;
                    _subtitleTextBoxBottomLeft.SelectionStart = entry.Key;
                    _subtitleTextBoxBottomLeft.SelectionLength = entry.Value;
                    _subtitleTextBoxBottomLeft.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                    _subtitleTextBoxBottomLeft.DeselectAll();
                }
                foreach (var entry in fontColorLookups)
                {
                    _subtitleTextBoxBottomLeft.SelectionStart = entry.Key.X;
                    _subtitleTextBoxBottomLeft.SelectionLength = entry.Key.Y;
                    _subtitleTextBoxBottomLeft.SelectionColor = entry.Value;
                    _subtitleTextBoxBottomLeft.DeselectAll();
                }

            }
        }

        public string SubtitleTextBottomRight
        {
            get
            {
                return _subtitleTextBottomRight;
            }
            set
            {
                _subtitleTextBottomRight = value;

                bool BottomLeft = _subtitleTextBottomRight.StartsWith("{\\a1}", StringComparison.Ordinal) || _subtitleTextBottomRight.StartsWith("{\\an1}", StringComparison.Ordinal);

                bool BottomCenter = _subtitleTextBottomRight.StartsWith("{\\a2}", StringComparison.Ordinal) || _subtitleTextBottomRight.StartsWith("{\\an2}", StringComparison.Ordinal);

                bool BottomRight = _subtitleTextBottomRight.StartsWith("{\\a3}", StringComparison.Ordinal) || _subtitleTextBottomRight.StartsWith("{\\an3}", StringComparison.Ordinal);

               // bool MiddleLeft = _subtitleTextBottomRight.StartsWith("{\\a4}", StringComparison.Ordinal) || _subtitleTextBottomRight.StartsWith("{\\an4}", StringComparison.Ordinal);

                bool MiddleCenter = _subtitleTextBottomRight.StartsWith("{\\a5}", StringComparison.Ordinal) || _subtitleTextBottomRight.StartsWith("{\\an5}", StringComparison.Ordinal);

               // bool MiddleRight = _subtitleTextBottomRight.StartsWith("{\\a6}", StringComparison.Ordinal) || _subtitleTextBottomRight.StartsWith("{\\an6}", StringComparison.Ordinal);

                bool TopLeft = _subtitleTextBottomRight.StartsWith("{\\a7}", StringComparison.Ordinal) || _subtitleTextBottomRight.StartsWith("{\\an7}", StringComparison.Ordinal);

                bool TopCenter = _subtitleTextBottomRight.StartsWith("{\\a8}", StringComparison.Ordinal) || _subtitleTextBottomRight.StartsWith("{\\an8}", StringComparison.Ordinal);

                bool TopRight = _subtitleTextBottomRight.StartsWith("{\\a9}", StringComparison.Ordinal) || _subtitleTextBottomRight.StartsWith("{\\an9}", StringComparison.Ordinal);

                string text = RemoveSubStationAlphaFormatting(_subtitleTextBottomRight);
                // Test with IndexOf method.
                if (text.IndexOf("\t") != -1)
                {
                    text = text.Substring(text.IndexOf("\t"));
                    text = HtmlUtil.RemoveOpenCloseTags(text, HtmlUtil.TagBold, HtmlUtil.TagUnderline);
                    text = text.Replace("<i></i>", string.Empty);
                    //_panelSubtitleUpper.Visible = true;
                    if (text == null || text == "")
                    {
                        _subtitleTextBoxBottomRight.Visible = false;
                    }
                    else
                    {
                        _subtitleTextBoxBottomRight.Visible = true;
                    }
                }
                else
                {
                    text = HtmlUtil.RemoveOpenCloseTags(text, HtmlUtil.TagBold, HtmlUtil.TagUnderline);
                    text = text.Replace("<i></i>", string.Empty);
                    // _panelSubtitleUpper.Visible = true;
                    if (text == null || text == "")
                    {
                        _subtitleTextBoxBottomRight.Visible = false;
                    }
                    else
                    {
                        _subtitleTextBoxBottomRight.Visible = true;
                    }
                }

                // display italic
                var sb = new StringBuilder();
                int i = 0;
                bool isItalic = false;
                bool isFontColor = false;
                int italicBegin = 0;
                int fontColorBegin = 0;
                _subtitleTextBoxBottomRight.Text = string.Empty;
                int letterCount = 0;
                var italicLookups = new System.Collections.Generic.Dictionary<int, int>();
                var fontColorLookups = new System.Collections.Generic.Dictionary<Point, Color>();
                Color fontColor = Color.White;
                while (i < text.Length)
                {
                    if (text.Substring(i).StartsWith("<i>", StringComparison.OrdinalIgnoreCase))
                    {
                        _subtitleTextBoxBottomRight.AppendText(sb.ToString());
                        sb = new StringBuilder();
                        isItalic = true;
                        italicBegin = letterCount;
                        i += 2;
                    }
                    else if (text.Substring(i).StartsWith("</i>", StringComparison.OrdinalIgnoreCase) && isItalic)
                    {
                        italicLookups.Add(italicBegin, _subtitleTextBoxBottomRight.Text.Length + sb.ToString().Length - italicBegin);
                        _subtitleTextBoxBottomRight.AppendText(sb.ToString());
                        sb = new StringBuilder();
                        isItalic = false;
                        i += 3;
                    }
                    else if (text.Substring(i).StartsWith("<font ", StringComparison.OrdinalIgnoreCase))
                    {
                        string s = text.Substring(i);
                        bool fontFound = false;
                        int end = s.IndexOf('>');
                        if (end > 0)
                        {
                            string f = s.Substring(0, end);
                            int colorStart = f.IndexOf(" color=", StringComparison.Ordinal);

                            if (colorStart > 0)
                            {
                                int colorEnd = colorStart + " color=".Length + 1;
                                if (colorEnd < f.Length)
                                {
                                    colorEnd = f.IndexOf('"', colorEnd);
                                    if (colorEnd > 0 || colorEnd == -1)
                                    {
                                        if (colorEnd == -1)
                                            s = f.Substring(colorStart);
                                        else
                                            s = f.Substring(colorStart, colorEnd - colorStart);
                                        s = s.Remove(0, " color=".Length);
                                        s = s.Trim('"');
                                        s = s.Trim('\'');
                                        try
                                        {
                                            fontColor = ColorTranslator.FromHtml(s);
                                            fontFound = true;
                                        }
                                        catch
                                        {
                                            fontFound = false;
                                            if (s.Length > 0)
                                            {
                                                try
                                                {
                                                    fontColor = ColorTranslator.FromHtml("#" + s);
                                                    fontFound = true;
                                                }
                                                catch
                                                {
                                                    fontFound = false;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            i += end;
                        }
                        if (fontFound)
                        {
                            _subtitleTextBoxBottomRight.AppendText(sb.ToString());
                            sb = new StringBuilder();
                            isFontColor = true;
                            fontColorBegin = letterCount;
                        }
                    }
                    else if (text.Substring(i).StartsWith("</font>", StringComparison.OrdinalIgnoreCase) && isFontColor)
                    {
                        fontColorLookups.Add(new Point(fontColorBegin, _subtitleTextBoxBottomRight.Text.Length + sb.ToString().Length - fontColorBegin), fontColor);
                        _subtitleTextBoxBottomRight.AppendText(sb.ToString());
                        sb = new StringBuilder();
                        isFontColor = false;
                        i += 6;
                    }
                    else if (text[i] == '\n') // RichTextBox only count NewLine as one character!
                    {
                        sb.Append(text[i]);
                    }
                    else
                    {
                        sb.Append(text[i]);
                        letterCount++;
                    }
                    i++;
                }
                _subtitleTextBoxBottomRight.Text += sb.ToString();
                _subtitleTextBoxBottomRight.SelectAll();
                if (BottomLeft)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = true;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (BottomCenter)
                {
                    _subtitleTextBoxUpper.Visible = true;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (BottomRight)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = true;
                }
                else if (MiddleCenter)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = true;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (TopLeft)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = true;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (TopCenter)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = true;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = false;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else if (TopRight)
                {
                    _subtitleTextBoxUpper.Visible = false;
                    _subtitleTextBoxUpperTop.Visible = false;
                    _subtitleTextBoxUpperTopLeft.Visible = false;
                    _subtitleTextBoxUpperTopRight.Visible = true;
                    _subtitleTextBoxUpperCenter.Visible = false;
                    _subtitleTextBoxBottomLeft.Visible = false;
                    _subtitleTextBoxBottomRight.Visible = false;
                }
                else
                {
                    _subtitleTextBoxBottomRight.Visible = false;
                }


                _subtitleTextBoxBottomRight.DeselectAll();
                foreach (var entry in italicLookups)
                {
                    Font currentFont = _subtitleTextBoxBottomRight.SelectionFont;
                    FontStyle newFontStyle = FontStyle.Italic | FontStyle.Bold;
                    if (!Configuration.Settings.General.VideoPlayerPreviewFontBold)
                        newFontStyle = FontStyle.Italic;
                    _subtitleTextBoxBottomRight.SelectionStart = entry.Key;
                    _subtitleTextBoxBottomRight.SelectionLength = entry.Value;
                    _subtitleTextBoxBottomRight.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                    _subtitleTextBoxBottomRight.DeselectAll();
                }
                foreach (var entry in fontColorLookups)
                {
                    _subtitleTextBoxBottomRight.SelectionStart = entry.Key.X;
                    _subtitleTextBoxBottomRight.SelectionLength = entry.Key.Y;
                    _subtitleTextBoxBottomRight.SelectionColor = entry.Value;
                    _subtitleTextBoxBottomRight.DeselectAll();
                }

            }
        }

        private void PanelPlayerMouseDown(object sender, MouseEventArgs e)
        {
            TogglePlayPause();
        }

        public void InitializeVolume(double defaultVolume)
        {
            int maxVolume = _pictureBoxVolumeBarBackground.Width - 18;
            _pictureBoxVolumeBar.Width = (int)(maxVolume * defaultVolume / 100.0);
        }

        private Control MakePlayerPanel()
        {
            PanelPlayer = new Panel { BackColor = _backgroundColor, Left = 0, Top = 0 };
            return PanelPlayer;
        }

        public void HideControls()
        {
            if (_panelcontrols.Visible)
            {
                //_panelSubtitle.Height = _panelSubtitle.Height + _controlsHeight;
                //_panelSubtitleUpper.Height = _panelSubtitleUpper.Height + _controlsHeight;
                _panelcontrols.Visible = false;
            }
        }

        public void ShowControls()
        {
            if (!_panelcontrols.Visible)
            {
                _panelcontrols.Visible = true;
                //_panelSubtitle.Height = _panelSubtitle.Height - _controlsHeight;
                //_panelSubtitleUpper.Height = _panelSubtitleUpper.Height - _controlsHeight;
            }
        }

        private Control MakeControlsPanel()
        {
            _panelcontrols = new Panel { Left = 0, Height = _controlsHeight };

            _pictureBoxBackground = new PictureBox
            {
                Image = (Image)_resources.GetObject("pictureBoxBar.Image"),
                Location = new Point(0, 0),
                Name = "_pictureBoxBackground",
                Size = new Size(200, 45),
                SizeMode = PictureBoxSizeMode.StretchImage,
                TabStop = false
            };
            _panelcontrols.Controls.Add(_pictureBoxBackground);

            _pictureBoxPlay = new PictureBox
            {
                Image = (Image)_resources.GetObject("pictureBoxPlay.Image"),
                Location = new Point(22, 126 - 113),
                Name = "_pictureBoxPlay",
                Size = new Size(29, 29),
                SizeMode = PictureBoxSizeMode.AutoSize,
                TabStop = false
            };
            _pictureBoxPlay.MouseEnter += PictureBoxPlayMouseEnter;
            _panelcontrols.Controls.Add(_pictureBoxPlay);

            _pictureBoxPlayDown = new PictureBox
            {
                Image = (Image)_resources.GetObject("pictureBoxPlayDown.Image"),
                Location = new Point(22, 127 - 113),
                Name = "_pictureBoxPlayDown",
                Size = new Size(29, 29),
                SizeMode = PictureBoxSizeMode.AutoSize,
                TabStop = false
            };
            _panelcontrols.Controls.Add(_pictureBoxPlayDown);

            _pictureBoxPlayOver = new PictureBox
            {
                Image = (Image)_resources.GetObject("pictureBoxPlayOver.Image"),
                Location = new Point(23, 126 - 113),
                Name = "_pictureBoxPlayOver",
                Size = new Size(29, 29),
                SizeMode = PictureBoxSizeMode.AutoSize,
                TabStop = false
            };
            _pictureBoxPlayOver.MouseLeave += PictureBoxPlayOverMouseLeave;
            _pictureBoxPlayOver.MouseDown += PictureBoxPlayOverMouseDown;
            _pictureBoxPlayOver.MouseUp += PictureBoxPlayOverMouseUp;
            _panelcontrols.Controls.Add(_pictureBoxPlayOver);

            _pictureBoxPause.Image = (Image)_resources.GetObject("pictureBoxPause.Image");
            _pictureBoxPause.Location = new Point(23, 126 - 113);
            _pictureBoxPause.Name = "_pictureBoxPause";
            _pictureBoxPause.Size = new Size(29, 29);
            _pictureBoxPause.SizeMode = PictureBoxSizeMode.AutoSize;
            _pictureBoxPause.TabStop = false;
            _pictureBoxPause.MouseEnter += PictureBoxPauseMouseEnter;
            _panelcontrols.Controls.Add(_pictureBoxPause);

            _pictureBoxPauseDown.Image = (Image)_resources.GetObject("pictureBoxPauseDown.Image");
            _pictureBoxPauseDown.Location = new Point(22, 127 - 113);
            _pictureBoxPauseDown.Name = "_pictureBoxPauseDown";
            _pictureBoxPauseDown.Size = new Size(29, 29);
            _pictureBoxPauseDown.SizeMode = PictureBoxSizeMode.AutoSize;
            _pictureBoxPauseDown.TabStop = false;
            _panelcontrols.Controls.Add(_pictureBoxPauseDown);

            _pictureBoxPauseOver.Image = (Image)_resources.GetObject("pictureBoxPauseOver.Image");
            _pictureBoxPauseOver.Location = new Point(22, 127 - 113);
            _pictureBoxPauseOver.Name = "_pictureBoxPauseOver";
            _pictureBoxPauseOver.Size = new Size(29, 29);
            _pictureBoxPauseOver.SizeMode = PictureBoxSizeMode.AutoSize;
            _pictureBoxPauseOver.TabStop = false;
            _pictureBoxPauseOver.MouseLeave += PictureBoxPauseOverMouseLeave;
            _pictureBoxPauseOver.MouseDown += PictureBoxPauseOverMouseDown;
            _pictureBoxPauseOver.MouseUp += PictureBoxPauseOverMouseUp;
            _panelcontrols.Controls.Add(_pictureBoxPauseOver);

            _pictureBoxStop.Image = (Image)_resources.GetObject("pictureBoxStop.Image");
            _pictureBoxStop.Location = new Point(52, 130 - 113);
            _pictureBoxStop.Name = "_pictureBoxStop";
            _pictureBoxStop.Size = new Size(20, 20);
            _pictureBoxStop.SizeMode = PictureBoxSizeMode.AutoSize;
            _pictureBoxStop.TabStop = false;
            _pictureBoxStop.MouseEnter += PictureBoxStopMouseEnter;
            _panelcontrols.Controls.Add(_pictureBoxStop);

            _pictureBoxStopDown.Image = (Image)_resources.GetObject("pictureBoxStopDown.Image");
            _pictureBoxStopDown.Location = new Point(52, 130 - 113);
            _pictureBoxStopDown.Name = "_pictureBoxStopDown";
            _pictureBoxStopDown.Size = new Size(20, 20);
            _pictureBoxStopDown.SizeMode = PictureBoxSizeMode.AutoSize;
            _pictureBoxStopDown.TabStop = false;
            _panelcontrols.Controls.Add(_pictureBoxStopDown);

            _pictureBoxStopOver.Image = (Image)_resources.GetObject("pictureBoxStopOver.Image");
            _pictureBoxStopOver.Location = new Point(52, 130 - 113);
            _pictureBoxStopOver.Name = "_pictureBoxStopOver";
            _pictureBoxStopOver.Size = new Size(20, 20);
            _pictureBoxStopOver.SizeMode = PictureBoxSizeMode.AutoSize;
            _pictureBoxStopOver.TabStop = false;
            _pictureBoxStopOver.MouseLeave += PictureBoxStopOverMouseLeave;
            _pictureBoxStopOver.MouseDown += PictureBoxStopOverMouseDown;
            _pictureBoxStopOver.MouseUp += PictureBoxStopOverMouseUp;
            _panelcontrols.Controls.Add(_pictureBoxStopOver);

            _pictureBoxFullscreen.Image = (Image)_resources.GetObject("pictureBoxFS.Image");
            _pictureBoxFullscreen.Location = new Point(95, 130 - 113);
            _pictureBoxFullscreen.Name = "_pictureBoxFullscreen";
            _pictureBoxFullscreen.Size = new Size(20, 20);
            _pictureBoxFullscreen.SizeMode = PictureBoxSizeMode.AutoSize;
            _pictureBoxFullscreen.TabStop = false;
            _pictureBoxFullscreen.MouseEnter += PictureBoxFullscreenMouseEnter;
            _panelcontrols.Controls.Add(_pictureBoxFullscreen);

            _pictureBoxFullscreenDown.Image = (Image)_resources.GetObject("pictureBoxFSDown.Image");
            _pictureBoxFullscreenDown.Location = new Point(95, 130 - 113);
            _pictureBoxFullscreenDown.Name = "_pictureBoxFullscreenDown";
            _pictureBoxFullscreenDown.Size = new Size(20, 20);
            _pictureBoxFullscreenDown.SizeMode = PictureBoxSizeMode.AutoSize;
            _pictureBoxFullscreenDown.TabStop = false;
            _panelcontrols.Controls.Add(_pictureBoxFullscreenDown);

            _pictureBoxFullscreenOver.Image = (Image)_resources.GetObject("pictureBoxFSOver.Image");
            _pictureBoxFullscreenOver.Location = new Point(95, 130 - 113);
            _pictureBoxFullscreenOver.Name = "_pictureBoxFullscreenOver";
            _pictureBoxFullscreenOver.Size = new Size(20, 20);
            _pictureBoxFullscreenOver.SizeMode = PictureBoxSizeMode.AutoSize;
            _pictureBoxFullscreenOver.TabStop = false;
            _pictureBoxFullscreenOver.MouseLeave += PictureBoxFullscreenOverMouseLeave;
            _pictureBoxFullscreenOver.MouseDown += PictureBoxFullscreenOverMouseDown;
            _pictureBoxFullscreenOver.MouseUp += PictureBoxFullscreenOverMouseUp;
            _panelcontrols.Controls.Add(_pictureBoxFullscreenOver);

            _pictureBoxProgressbarBackground.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            _pictureBoxProgressbarBackground.BackColor = Color.Transparent;
            _pictureBoxProgressbarBackground.Image = (Image)_resources.GetObject("pictureBoxProgressbarBackground.Image");
            _pictureBoxProgressbarBackground.Location = new Point(43, 114 - 113);
            _pictureBoxProgressbarBackground.Margin = new Padding(0);
            _pictureBoxProgressbarBackground.Name = "_pictureBoxProgressbarBackground";
            _pictureBoxProgressbarBackground.Size = new Size(531, 12);
            _pictureBoxProgressbarBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            _pictureBoxProgressbarBackground.TabStop = false;
            _pictureBoxProgressbarBackground.MouseDown += PictureBoxProgressbarBackgroundMouseDown;
            _panelcontrols.Controls.Add(_pictureBoxProgressbarBackground);

            _pictureBoxProgressBar.Image = (Image)_resources.GetObject("pictureBoxProgressBar.Image");
            _pictureBoxProgressBar.Location = new Point(47, 118 - 113);
            _pictureBoxProgressBar.Name = "_pictureBoxProgressBar";
            _pictureBoxProgressBar.Size = new Size(318, 4);
            _pictureBoxProgressBar.SizeMode = PictureBoxSizeMode.StretchImage;
            _pictureBoxProgressBar.TabStop = false;
            _pictureBoxProgressBar.MouseDown += PictureBoxProgressBarMouseDown;
            _panelcontrols.Controls.Add(_pictureBoxProgressBar);
            _pictureBoxProgressBar.BringToFront();

            _pictureBoxMute.Image = (Image)_resources.GetObject("pictureBoxMute.Image");
            _pictureBoxMute.Location = new Point(75, 131 - 113);
            _pictureBoxMute.Name = "_pictureBoxMute";
            _pictureBoxMute.Size = new Size(19, 19);
            _pictureBoxMute.SizeMode = PictureBoxSizeMode.AutoSize;
            _pictureBoxMute.TabStop = false;
            _pictureBoxMute.MouseEnter += PictureBoxMuteMouseEnter;
            _panelcontrols.Controls.Add(_pictureBoxMute);

            _pictureBoxMuteDown.Image = (Image)_resources.GetObject("pictureBoxMuteDown.Image");
            _pictureBoxMuteDown.Location = new Point(75, 131 - 113);
            _pictureBoxMuteDown.Name = "_pictureBoxMuteDown";
            _pictureBoxMuteDown.Size = new Size(19, 19);
            _pictureBoxMuteDown.SizeMode = PictureBoxSizeMode.AutoSize;
            _pictureBoxMuteDown.TabStop = false;
            _pictureBoxMuteDown.Click += PictureBoxMuteDownClick;
            _panelcontrols.Controls.Add(_pictureBoxMuteDown);

            _pictureBoxMuteOver.Image = (Image)_resources.GetObject("pictureBoxMuteOver.Image");
            _pictureBoxMuteOver.Location = new Point(75, 131 - 113);
            _pictureBoxMuteOver.Name = "_pictureBoxMuteOver";
            _pictureBoxMuteOver.Size = new Size(19, 19);
            _pictureBoxMuteOver.SizeMode = PictureBoxSizeMode.AutoSize;
            _pictureBoxMuteOver.TabStop = false;
            _pictureBoxMuteOver.MouseLeave += PictureBoxMuteOverMouseLeave;
            _pictureBoxMuteOver.MouseDown += PictureBoxMuteOverMouseDown;
            _pictureBoxMuteOver.MouseUp += PictureBoxMuteOverMouseUp;
            _panelcontrols.Controls.Add(_pictureBoxMuteOver);

            _pictureBoxVolumeBarBackground.Image = (Image)_resources.GetObject("pictureBoxVolumeBarBackground.Image");
            _pictureBoxVolumeBarBackground.Location = new Point(111, 135 - 113);
            _pictureBoxVolumeBarBackground.Name = "_pictureBoxVolumeBarBackground";
            _pictureBoxVolumeBarBackground.Size = new Size(82, 13);
            _pictureBoxVolumeBarBackground.SizeMode = PictureBoxSizeMode.AutoSize;
            _pictureBoxVolumeBarBackground.TabStop = false;
            _pictureBoxVolumeBarBackground.MouseDown += PictureBoxVolumeBarBackgroundMouseDown;
            _panelcontrols.Controls.Add(_pictureBoxVolumeBarBackground);

            _pictureBoxVolumeBar.Image = (Image)_resources.GetObject("pictureBoxVolumeBar.Image");
            _pictureBoxVolumeBar.Location = new Point(120, 139 - 113);
            _pictureBoxVolumeBar.Name = "_pictureBoxVolumeBar";
            _pictureBoxVolumeBar.Size = new Size(48, 4);
            _pictureBoxVolumeBar.SizeMode = PictureBoxSizeMode.StretchImage;
            _pictureBoxVolumeBar.TabStop = false;
            _pictureBoxVolumeBar.MouseDown += PictureBoxVolumeBarMouseDown;
            _panelcontrols.Controls.Add(_pictureBoxVolumeBar);
            _pictureBoxVolumeBar.BringToFront();

            _pictureBoxReverse = new PictureBox
            {
                Image = (Image)_resources.GetObject("pictureBoxReverse.Image"),
                Location = new Point(28, 3),
                Name = "_pictureBoxReverse",
                Size = new Size(16, 8),
                SizeMode = PictureBoxSizeMode.AutoSize,
                TabStop = false
            };
            _panelcontrols.Controls.Add(_pictureBoxReverse);
            _pictureBoxReverse.MouseEnter += PictureBoxReverseMouseEnter;

            _pictureBoxReverseOver = new PictureBox
            {
                Image = (Image)_resources.GetObject("pictureBoxReverseMouseOver.Image"),
                Location = _pictureBoxReverse.Location,
                Name = "_pictureBoxReverseOver",
                Size = _pictureBoxReverse.Size,
                SizeMode = PictureBoxSizeMode.AutoSize,
                TabStop = false
            };
            _panelcontrols.Controls.Add(_pictureBoxReverseOver);
            _pictureBoxReverseOver.MouseLeave += PictureBoxReverseOverMouseLeave;
            _pictureBoxReverseOver.MouseDown += PictureBoxReverseOverMouseDown;
            _pictureBoxReverseOver.MouseUp += PictureBoxReverseOverMouseUp;

            _pictureBoxReverseDown = new PictureBox
            {
                Image = (Image)_resources.GetObject("pictureBoxReverseMouseDown.Image"),
                Location = _pictureBoxReverse.Location,
                Name = "_pictureBoxReverseOver",
                Size = _pictureBoxReverse.Size,
                SizeMode = PictureBoxSizeMode.AutoSize,
                TabStop = false
            };
            _panelcontrols.Controls.Add(_pictureBoxReverseDown);

            _pictureBoxFastForward = new PictureBox
            {
                Image = (Image)_resources.GetObject("pictureBoxFastForward.Image"),
                Location = new Point(571, 1),
                Name = "_pictureBoxFastForward",
                Size = new Size(17, 13),
                SizeMode = PictureBoxSizeMode.AutoSize,
                TabStop = false
            };
            _panelcontrols.Controls.Add(_pictureBoxFastForward);
            _pictureBoxFastForward.MouseEnter += PictureBoxFastForwardMouseEnter;

            _pictureBoxFastForwardOver = new PictureBox
            {
                Image = (Image)_resources.GetObject("pictureBoxFastForwardMouseOver.Image"),
                Location = _pictureBoxFastForward.Location,
                Name = "_pictureBoxFastForwardOver",
                Size = _pictureBoxFastForward.Size,
                SizeMode = PictureBoxSizeMode.AutoSize,
                TabStop = false
            };
            _panelcontrols.Controls.Add(_pictureBoxFastForwardOver);
            _pictureBoxFastForwardOver.MouseLeave += PictureBoxFastForwardOverMouseLeave;
            _pictureBoxFastForwardOver.MouseDown += PictureBoxFastForwardOverMouseDown;
            _pictureBoxFastForwardOver.MouseUp += PictureBoxFastForwardOverMouseUp;

            _pictureBoxFastForwardDown = new PictureBox
            {
                Image = (Image)_resources.GetObject("pictureBoxFastForwardMouseDown.Image"),
                Location = _pictureBoxFastForward.Location,
                Name = "_pictureBoxFastForwardDown",
                Size = _pictureBoxFastForward.Size,
                SizeMode = PictureBoxSizeMode.AutoSize,
                TabStop = false
            };
            _panelcontrols.Controls.Add(_pictureBoxFastForwardDown);

            _labelTimeCode.Location = new Point(280, 28);
            _labelTimeCode.ForeColor = Color.Gray;
            _labelTimeCode.Font = new Font(_labelTimeCode.Font.FontFamily, 7);
            _labelTimeCode.AutoSize = true;
            _panelcontrols.Controls.Add(_labelTimeCode);

            _labelVideoPlayerName.Location = new Point(280, 17);
            _labelVideoPlayerName.ForeColor = Color.Gray;
            _labelVideoPlayerName.BackColor = Color.FromArgb(67, 75, 93);
            _labelVideoPlayerName.AutoSize = true;
            _labelVideoPlayerName.Font = new Font(_labelTimeCode.Font.FontFamily, 5);

            _panelcontrols.Controls.Add(_labelVideoPlayerName);

            _pictureBoxBackground.SendToBack();
            _pictureBoxFastForward.BringToFront();
            _pictureBoxFastForwardDown.BringToFront();
            _pictureBoxFastForwardOver.BringToFront();
            _pictureBoxPlay.BringToFront();

            _panelcontrols.BackColor = _backgroundColor;
            _pictureBoxPlay.BringToFront();
            _pictureBoxPlayDown.BringToFront();
            _pictureBoxPlayOver.BringToFront();
            _labelTimeCode.BringToFront();
            return _panelcontrols;
        }

        public void VideoPlayerContainerResize(object sender, EventArgs e)
        {
            _controlsHeight = _pictureBoxBackground.Height;
            PanelPlayer.Height = Height - (_controlsHeight + SubtitlesHeight);
            PanelPlayer.Width = Width;
            if (_videoPlayer != null)
                _videoPlayer.Resize(PanelPlayer.Width, PanelPlayer.Height);

            //_panelSubtitle.Top = Height - (_controlsHeight + SubtitlesHeight);
            //_panelSubtitle.Width = Width;

            //_panelSubtitleUpper.Top = SubtitlesHeightUpper;
            //_panelSubtitleUpper.Width = Width;

            _panelcontrols.Top = Height - _controlsHeight + 2;
            _panelcontrols.Width = Width;

            _pictureBoxBackground.Width = Width;
            _pictureBoxProgressbarBackground.Width = Width - (_pictureBoxProgressbarBackground.Left * 2);
            _pictureBoxFastForward.Left = Width - 48;
            _pictureBoxFastForwardDown.Left = _pictureBoxFastForward.Left;
            _pictureBoxFastForwardOver.Left = _pictureBoxFastForward.Left;

            _labelTimeCode.Left = Width - 170;
            _labelVideoPlayerName.Left = Width - _labelVideoPlayerName.Width - 3;
        }

        #region PlayPauseButtons

        public void RefreshPlayPauseButtons()
        {
            if (VideoPlayer != null)
            {
                if (VideoPlayer.IsPlaying)
                {
                    if (!_pictureBoxPause.Visible && !_pictureBoxPauseDown.Visible && !_pictureBoxPauseOver.Visible)
                    {
                        HideAllPauseImages();
                        HideAllPlayImages();
                        _pictureBoxPause.Visible = true;
                        _pictureBoxPause.BringToFront();
                    }
                }
                else
                {
                    if (!_pictureBoxPlay.Visible && !_pictureBoxPlayOver.Visible && !_pictureBoxPlayDown.Visible)
                    {
                        HideAllPauseImages();
                        HideAllPlayImages();
                        _pictureBoxPlay.Visible = true;
                        _pictureBoxPlay.BringToFront();
                    }
                }
            }
        }

        private void HideAllPlayImages()
        {
            _pictureBoxPlayOver.Visible = false;
            _pictureBoxPlayDown.Visible = false;
            _pictureBoxPlay.Visible = false;
        }

        private void PictureBoxPlayMouseEnter(object sender, EventArgs e)
        {
            if (_pictureBoxPlay.Visible)
            {
                HideAllPlayImages();
                _pictureBoxPlayOver.Visible = true;
                _pictureBoxPlayOver.BringToFront();
            }
        }

        private void PictureBoxPlayOverMouseLeave(object sender, EventArgs e)
        {
            if (_pictureBoxPlayOver.Visible)
            {
                HideAllPlayImages();
                _pictureBoxPlay.Visible = true;
                _pictureBoxPlay.BringToFront();
            }
        }

        private void PictureBoxPlayOverMouseDown(object sender, MouseEventArgs e)
        {
            HideAllPlayImages();
            _pictureBoxPlayDown.Visible = true;
            _pictureBoxPlayDown.BringToFront();
            if (OnButtonClicked != null)
                OnButtonClicked.Invoke(sender, e);
        }

        private void PictureBoxPlayOverMouseUp(object sender, MouseEventArgs e)
        {
            HideAllPlayImages();
            _pictureBoxPause.Visible = true;
            _pictureBoxPause.BringToFront();
            Play();
        }

        private void HideAllPauseImages()
        {
            _pictureBoxPauseOver.Visible = false;
            _pictureBoxPauseDown.Visible = false;
            _pictureBoxPause.Visible = false;
        }

        private void PictureBoxPauseMouseEnter(object sender, EventArgs e)
        {
            if (_pictureBoxPause.Visible)
            {
                HideAllPauseImages();
                _pictureBoxPauseOver.Visible = true;
            }
        }

        private void PictureBoxPauseOverMouseLeave(object sender, EventArgs e)
        {
            if (_pictureBoxPauseOver.Visible)
            {
                HideAllPauseImages();
                _pictureBoxPause.Visible = true;
                _pictureBoxPause.BringToFront();
            }
        }

        private void PictureBoxPauseOverMouseDown(object sender, MouseEventArgs e)
        {
            if (_pictureBoxPauseOver.Visible)
            {
                HideAllPauseImages();
                _pictureBoxPauseDown.Visible = true;
            }
            if (OnButtonClicked != null)
                OnButtonClicked.Invoke(sender, e);
        }

        private void PictureBoxPauseOverMouseUp(object sender, MouseEventArgs e)
        {
            HideAllPauseImages();
            _pictureBoxPlay.Visible = true;
            Pause();
        }

        #endregion PlayPauseButtons

        #region StopButtons

        private void HideAllStopImages()
        {
            _pictureBoxStopOver.Visible = false;
            _pictureBoxStopDown.Visible = false;
            _pictureBoxStop.Visible = false;
        }

        private void PictureBoxStopMouseEnter(object sender, EventArgs e)
        {
            HideAllStopImages();
            _pictureBoxStopOver.Visible = true;
        }

        private void PictureBoxStopOverMouseLeave(object sender, EventArgs e)
        {
            if (_pictureBoxStopOver.Visible)
            {
                HideAllStopImages();
                _pictureBoxStop.Visible = true;
            }
        }

        private void PictureBoxStopOverMouseDown(object sender, MouseEventArgs e)
        {
            if (_pictureBoxStopOver.Visible)
            {
                HideAllStopImages();
                _pictureBoxStopDown.Visible = true;
            }
            if (OnButtonClicked != null)
                OnButtonClicked.Invoke(sender, e);
        }

        private void PictureBoxStopOverMouseUp(object sender, MouseEventArgs e)
        {
            HideAllStopImages();
            _pictureBoxStop.Visible = true;
            Stop();
        }

        #endregion StopButtons

        #region FullscreenButtons

        private void HideAllFullscreenImages()
        {
            _pictureBoxFullscreenOver.Visible = false;
            _pictureBoxFullscreenDown.Visible = false;
            _pictureBoxFullscreen.Visible = false;
        }

        public void ShowFullScreenControls()
        {
            _pictureBoxFullscreen.Image = (Image)_resources.GetObject("pictureBoxNoFS.Image");
            _pictureBoxFullscreenDown.Image = (Image)_resources.GetObject("pictureBoxNoFSDown.Image");
            _pictureBoxFullscreenOver.Image = (Image)_resources.GetObject("pictureBoxNoFSOver.Image");
        }

        public void ShowNonFullScreenControls()
        {
            _pictureBoxFullscreen.Image = (Image)_resources.GetObject("pictureBoxFS.Image");
            _pictureBoxFullscreenDown.Image = (Image)_resources.GetObject("pictureBoxFSDown.Image");
            _pictureBoxFullscreenOver.Image = (Image)_resources.GetObject("pictureBoxFSOver.Image");
        }

        private void PictureBoxFullscreenMouseEnter(object sender, EventArgs e)
        {
            HideAllFullscreenImages();
            _pictureBoxFullscreenOver.Visible = true;
        }

        private void PictureBoxFullscreenOverMouseLeave(object sender, EventArgs e)
        {
            if (_pictureBoxFullscreenOver.Visible)
            {
                HideAllFullscreenImages();
                _pictureBoxFullscreen.Visible = true;
            }
        }

        private void PictureBoxFullscreenOverMouseDown(object sender, MouseEventArgs e)
        {
            HideAllFullscreenImages();
            if (OnButtonClicked != null)
                OnButtonClicked.Invoke(sender, e);
        }

        private void PictureBoxFullscreenOverMouseUp(object sender, MouseEventArgs e)
        {
            HideAllFullscreenImages();
            _pictureBoxFullscreen.Visible = true;
        }

        #endregion FullscreenButtons

        #region Mute buttons

        private void HideAllMuteImages()
        {
            _pictureBoxMuteOver.Visible = false;
            _pictureBoxMuteDown.Visible = false;
            _pictureBoxMute.Visible = false;
        }

        private void PictureBoxMuteMouseEnter(object sender, EventArgs e)
        {
            HideAllMuteImages();
            if (Mute)
                _pictureBoxMuteDown.Visible = true;
            else
                _pictureBoxMuteOver.Visible = true;
        }

        private void PictureBoxMuteOverMouseLeave(object sender, EventArgs e)
        {
            if (_pictureBoxMuteOver.Visible)
            {
                HideAllMuteImages();
                _pictureBoxMute.Visible = true;
            }
        }

        private void PictureBoxMuteOverMouseDown(object sender, MouseEventArgs e)
        {
            if (_pictureBoxMuteOver.Visible)
            {
                HideAllMuteImages();
                _pictureBoxMuteDown.Visible = true;
            }
            if (OnButtonClicked != null)
                OnButtonClicked.Invoke(sender, e);
        }

        private void PictureBoxMuteOverMouseUp(object sender, MouseEventArgs e)
        {
            HideAllMuteImages();
            Mute = true;
            _pictureBoxMuteDown.Visible = true;
        }

        private void PictureBoxMuteDownClick(object sender, EventArgs e)
        {
            Mute = false;
            HideAllMuteImages();
            _pictureBoxMute.Visible = true;
            if (OnButtonClicked != null)
                OnButtonClicked.Invoke(sender, e);
        }

        #endregion Mute buttons

        #region Reverse buttons

        private void HideAllReverseImages()
        {
            _pictureBoxReverseOver.Visible = false;
            _pictureBoxReverseDown.Visible = false;
            _pictureBoxReverse.Visible = false;
        }

        private void PictureBoxReverseMouseEnter(object sender, EventArgs e)
        {
            HideAllReverseImages();
            _pictureBoxReverseOver.Visible = true;
        }

        private void PictureBoxReverseOverMouseLeave(object sender, EventArgs e)
        {
            HideAllReverseImages();
            _pictureBoxReverse.Visible = true;
        }

        private void PictureBoxReverseOverMouseDown(object sender, MouseEventArgs e)
        {
            HideAllReverseImages();
            _pictureBoxReverseDown.Visible = true;
            if (VideoPlayer != null)
            {
                var newPosition = CurrentPosition - 3.0;
                if (newPosition < 0)
                    newPosition = 0;
                CurrentPosition = newPosition;
            }
        }

        private void PictureBoxReverseOverMouseUp(object sender, MouseEventArgs e)
        {
            HideAllReverseImages();
            _pictureBoxReverse.Visible = true;
        }

        #endregion Reverse buttons

        #region Fast forward buttons

        private void HideAllFastForwardImages()
        {
            _pictureBoxFastForwardOver.Visible = false;
            _pictureBoxFastForwardDown.Visible = false;
            _pictureBoxFastForward.Visible = false;
        }

        private void PictureBoxFastForwardMouseEnter(object sender, EventArgs e)
        {
            HideAllFastForwardImages();
            _pictureBoxFastForwardOver.Visible = true;
        }

        private void PictureBoxFastForwardOverMouseLeave(object sender, EventArgs e)
        {
            HideAllFastForwardImages();
            _pictureBoxFastForward.Visible = true;
        }

        private void PictureBoxFastForwardOverMouseDown(object sender, MouseEventArgs e)
        {
            HideAllFastForwardImages();
            _pictureBoxFastForwardDown.Visible = true;

            if (VideoPlayer != null)
            {
                var newPosition = CurrentPosition + 3.0;
                if (newPosition < 0)
                    newPosition = 0;
                CurrentPosition = newPosition;
            }
        }

        private void PictureBoxFastForwardOverMouseUp(object sender, MouseEventArgs e)
        {
            HideAllFastForwardImages();
            _pictureBoxFastForward.Visible = true;
        }

        #endregion Fast forward buttons

        #region Progress bars

        private void SetProgressBarPosition(int mouseX)
        {
            int max = _pictureBoxProgressbarBackground.Width - 9;
            if (mouseX > max)
                mouseX = max;

            double percent = (mouseX * 100.0) / max;
            _pictureBoxProgressBar.Width = (int)(max * percent / 100.0);

            CurrentPosition = percent * Duration / 100.0;
        }

        private void PictureBoxProgressbarBackgroundMouseDown(object sender, MouseEventArgs e)
        {
            SetProgressBarPosition(e.X - 4);
            if (OnButtonClicked != null)
                OnButtonClicked.Invoke(sender, e);
        }

        private void PictureBoxProgressBarMouseDown(object sender, MouseEventArgs e)
        {
            SetProgressBarPosition(e.X + 2);
            if (OnButtonClicked != null)
                OnButtonClicked.Invoke(sender, e);
        }

        public void RefreshProgressBar()
        {
            if (VideoPlayer == null)
            {
                _pictureBoxProgressBar.Width = 0;
            }
            else
            {
                int max = _pictureBoxProgressbarBackground.Width - 9;
                double percent = (VideoPlayer.CurrentPosition * 100.0) / VideoPlayer.Duration;
                _pictureBoxProgressBar.Width = (int)(max * percent / 100.0);

                if (Convert.ToInt64(Duration) == 0)
                    return;

                var pos = CurrentPosition;
                if (pos > 1000000)
                    pos = 0;
                var span = TimeCode.FromSeconds(pos + Configuration.Settings.General.CurrentVideoOffsetInMs / TimeCode.BaseUnit);
                var dur = TimeCode.FromSeconds(Duration + Configuration.Settings.General.CurrentVideoOffsetInMs / TimeCode.BaseUnit);

                _labelTimeCode.Text = string.Format("{0} / {1}", span.ToDisplayString(), dur.ToDisplayString());

                RefreshPlayPauseButtons();
            }
        }

        private void SetVolumeBarPosition(int mouseX)
        {
            int max = _pictureBoxVolumeBarBackground.Width - 18;
            if (mouseX > max)
                mouseX = max;

            double percent = (mouseX * 100.0) / max;
            _pictureBoxVolumeBar.Width = (int)(max * percent / 100.0);
            if (_videoPlayer != null)
                _videoPlayer.Volume = (int)percent;
            Configuration.Settings.General.VideoPlayerDefaultVolume = (int)percent;
        }

        private void PictureBoxVolumeBarBackgroundMouseDown(object sender, MouseEventArgs e)
        {
            SetVolumeBarPosition(e.X - 6);
            if (OnButtonClicked != null)
                OnButtonClicked.Invoke(sender, e);
        }

        private void PictureBoxVolumeBarMouseDown(object sender, MouseEventArgs e)
        {
            SetVolumeBarPosition(e.X + 2);
            if (OnButtonClicked != null)
                OnButtonClicked.Invoke(sender, e);
        }

        private void RefreshVolumeBar()
        {
            if (VideoPlayer == null)
            {
                _pictureBoxVolumeBar.Width = 0;
            }
            else
            {
                int max = _pictureBoxVolumeBarBackground.Width - 18;
                _pictureBoxVolumeBar.Width = (int)(max * Volume / 100.0);
            }
        }

        #endregion Progress bars

        #region VideoPlayer functions

        public void Play()
        {
            if (VideoPlayer != null)
            {
                VideoPlayer.Play();
                HideAllPlayImages();
                _pictureBoxPause.Visible = true;
                _pictureBoxPause.BringToFront();
                RefreshProgressBar();
            }
            if (OnButtonClicked != null)
                OnButtonClicked.Invoke(null, null);
        }

        public void Stop()
        {
            if (VideoPlayer != null)
            {
                VideoPlayer.Pause();
                HideAllPauseImages();
                _pictureBoxPlay.Visible = true;
                RefreshProgressBar();
            }
            if (OnButtonClicked != null)
                OnButtonClicked.Invoke(null, null);
        }

        public void Pause()
        {
            if (VideoPlayer != null)
            {
                VideoPlayer.Pause();
                HideAllPauseImages();
                _pictureBoxPlay.Visible = true;
                RefreshProgressBar();
            }
        }

        public void TogglePlayPause()
        {
            if (VideoPlayer != null)
            {
                if (VideoPlayer.IsPaused)
                    Play();
                else
                    Pause();
            }
        }

        public void TogglePlayPauseUpper()
        {
            if (VideoPlayer != null)
            {
                if (VideoPlayer.IsPaused)
                    Play();
                else
                    Pause();
            }
        }

        public bool IsPaused
        {
            get
            {
                if (VideoPlayer != null)
                {
                    return VideoPlayer.IsPaused;
                }
                return false;
            }
        }

        public double Volume
        {
            get
            {
                if (VideoPlayer != null)
                    return VideoPlayer.Volume;
                return 0;
            }
            set
            {
                if (VideoPlayer != null)
                {
                    if (value > 0)
                        _muteOldVolume = null;

                    if (value > 100)
                        VideoPlayer.Volume = 100;
                    else if (value < 0)
                        VideoPlayer.Volume = 0;
                    else
                        VideoPlayer.Volume = (int)value;

                    RefreshVolumeBar();
                }
            }
        }

        /// <summary>
        /// Current position in seconds
        /// </summary>
        public double CurrentPosition
        {
            get
            {
                if (VideoPlayer != null)
                    return VideoPlayer.CurrentPosition;
                return 0;
            }
            set
            {
                if (VideoPlayer != null)
                {
                    VideoPlayer.CurrentPosition = value;
                }
            }
        }

        /// <summary>
        /// Total duration in seconds
        /// </summary>
        public double Duration
        {
            get
            {
                if (VideoPlayer != null)
                    return VideoPlayer.Duration;
                return 0;
            }
        }

        private bool Mute
        {
            get
            {
                if (VideoPlayer != null)
                {
                    return _isMuted;
                }
                return false;
            }
            set
            {
                if (VideoPlayer != null)
                {
                    if (value == false && _muteOldVolume != null)
                    {
                        Volume = _muteOldVolume.Value;
                    }
                    else if (value)
                    {
                        _muteOldVolume = Volume;
                        Volume = 0;
                    }
                    _isMuted = value;
                }
            }
        }

        #endregion VideoPlayer functions

    }
}
