namespace ExceptionsValidationDemo;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        // ---- Layout: left sidebar + right content panel ----
        this.pnlSidebar   = new Panel();
        this.pnlContent   = new Panel();
        this.pnlHeader    = new Panel();
        this.lblHeader    = new Label();
        this.lblSubHeader = new Label();

        // ---- 8 nav buttons ----
        this.btnNav1 = MakeNavButton("1  Try-Catch");
        this.btnNav2 = MakeNavButton("2  Multi-Catch");
        this.btnNav3 = MakeNavButton("3  Finally");
        this.btnNav4 = MakeNavButton("4  Throw");
        this.btnNav5 = MakeNavButton("5  MessageBox");
        this.btnNav6 = MakeNavButton("6  Inline Validate");
        this.btnNav7 = MakeNavButton("7  Generic Methods");
        this.btnNav8 = MakeNavButton("8  TryParse vs Convert");

        // ---- 8 content panels (built before wiring) ----
        this.pnl1 = BuildPanel1();
        this.pnl2 = BuildPanel2();
        this.pnl3 = BuildPanel3();
        this.pnl4 = BuildPanel4();
        this.pnl5 = BuildPanel5();
        this.pnl6 = BuildPanel6();
        this.pnl7 = BuildPanel7();
        this.pnl8 = BuildPanel8();

        // Wire nav buttons
        this.btnNav1.Click += (s, e) => ShowPanel(0);
        this.btnNav2.Click += (s, e) => ShowPanel(1);
        this.btnNav3.Click += (s, e) => ShowPanel(2);
        this.btnNav4.Click += (s, e) => ShowPanel(3);
        this.btnNav5.Click += (s, e) => ShowPanel(4);
        this.btnNav6.Click += (s, e) => ShowPanel(5);
        this.btnNav7.Click += (s, e) => ShowPanel(6);
        this.btnNav8.Click += (s, e) => ShowPanel(7);

        // ---- Header ----
        this.pnlHeader.Dock      = DockStyle.Top;
        this.pnlHeader.Height    = 72;
        this.pnlHeader.BackColor = Color.FromArgb(30, 30, 46);

        this.lblHeader.Text      = "Guide #7 — Exceptions & Data Validation";
        this.lblHeader.Font      = new Font("Segoe UI Semibold", 16f, FontStyle.Bold);
        this.lblHeader.ForeColor = Color.FromArgb(205, 214, 244);
        this.lblHeader.Location  = new Point(14, 8);
        this.lblHeader.Size      = new Size(900, 34);
        this.lblHeader.AutoSize  = false;

        this.lblSubHeader.Text      = "C# WinForms Demo — Try-Catch · Finally · Throw · Validation · MessageBox · TryParse";
        this.lblSubHeader.Font      = new Font("Segoe UI", 10f);
        this.lblSubHeader.ForeColor = Color.FromArgb(147, 153, 178);
        this.lblSubHeader.Location  = new Point(14, 42);
        this.lblSubHeader.Size      = new Size(900, 24);

        this.pnlHeader.Controls.AddRange(new Control[] { lblHeader, lblSubHeader });

        // ---- Sidebar ----
        this.pnlSidebar.Dock      = DockStyle.Left;
        this.pnlSidebar.Width     = 235;
        this.pnlSidebar.BackColor = Color.FromArgb(24, 24, 37);

        Button[] navBtns = { btnNav1, btnNav2, btnNav3, btnNav4,
                              btnNav5, btnNav6, btnNav7, btnNav8 };
        int y = 14;
        foreach (var b in navBtns)
        {
            b.Location = new Point(8, y);
            this.pnlSidebar.Controls.Add(b);
            y += 58;
        }

        // ---- Content area ----
        this.pnlContent.Dock      = DockStyle.Fill;
        this.pnlContent.BackColor = Color.FromArgb(245, 245, 250);
        this.pnlContent.Padding   = new Padding(26);

        Panel[] contentPanels = { pnl1, pnl2, pnl3, pnl4, pnl5, pnl6, pnl7, pnl8 };
        foreach (var cp in contentPanels)
        {
            cp.Dock    = DockStyle.Fill;
            cp.Visible = false;
            this.pnlContent.Controls.Add(cp);
        }

        // ---- Form ----
        this.Text          = "Guide #7 — Exceptions & Data Validation";
        this.ClientSize    = new Size(1120, 700);
        this.MinimumSize   = new Size(1120, 700);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.BackColor     = Color.FromArgb(245, 245, 250);

        this.Controls.Add(this.pnlContent);
        this.Controls.Add(this.pnlSidebar);
        this.Controls.Add(this.pnlHeader);

        this.Load += (s, e) => ShowPanel(0);
    }

    // ----------------------------------------------------------------
    //  ShowPanel — hides all panels, shows selected one, highlights button
    // ----------------------------------------------------------------
    private Panel[]  _contentPanels = null!;
    private Button[] _navButtons    = null!;

    private void ShowPanel(int index)
    {
        _contentPanels ??= new[] { pnl1, pnl2, pnl3, pnl4, pnl5, pnl6, pnl7, pnl8 };
        _navButtons    ??= new[] { btnNav1, btnNav2, btnNav3, btnNav4,
                                   btnNav5, btnNav6, btnNav7, btnNav8 };

        for (int i = 0; i < _contentPanels.Length; i++)
        {
            _contentPanels[i].Visible = (i == index);

            bool active = (i == index);
            _navButtons[i].BackColor = active
                ? Color.FromArgb(137, 180, 250)
                : Color.FromArgb(24, 24, 37);
            _navButtons[i].ForeColor = active
                ? Color.FromArgb(24, 24, 37)
                : Color.FromArgb(205, 214, 244);
            _navButtons[i].Font = new Font("Segoe UI",
                active ? 11.5f : 11f,
                active ? FontStyle.Bold : FontStyle.Regular);
        }
    }

    // ================================================================
    //  Factory helpers
    // ================================================================
    private static Button MakeNavButton(string text)
    {
        return new Button
        {
            Text      = text,
            Size      = new Size(219, 50),
            FlatStyle = FlatStyle.Flat,
            BackColor = Color.FromArgb(24, 24, 37),
            ForeColor = Color.FromArgb(205, 214, 244),
            Font      = new Font("Segoe UI", 11f),
            TextAlign = ContentAlignment.MiddleLeft,
            Padding   = new Padding(12, 0, 0, 0),
            Cursor    = Cursors.Hand,
        };
    }

    private static Label MakeTitle(string text)
    {
        return new Label
        {
            Text      = text,
            Font      = new Font("Segoe UI Semibold", 17f, FontStyle.Bold),
            ForeColor = Color.FromArgb(30, 30, 46),
            Location  = new Point(0, 0),
            Size      = new Size(840, 38),
            AutoSize  = false,
        };
    }

    private static Label MakeInfo(string text)
    {
        return new Label
        {
            Text      = text,
            Font      = new Font("Segoe UI", 10.5f, FontStyle.Italic),
            ForeColor = Color.FromArgb(100, 108, 160),
            Location  = new Point(0, 42),
            Size      = new Size(840, 22),
            AutoSize  = false,
        };
    }

    private static Label MakeLabel(string text, int x, int y, int w = 120)
    {
        return new Label
        {
            Text      = text,
            Font      = new Font("Segoe UI", 12f, FontStyle.Bold),
            ForeColor = Color.FromArgb(50, 50, 80),
            Location  = new Point(x, y),
            Size      = new Size(w, 30),
            TextAlign = ContentAlignment.MiddleRight,
        };
    }

    private static TextBox MakeTextBox(int x, int y, int w = 180)
    {
        return new TextBox
        {
            Location = new Point(x, y),
            Size     = new Size(w, 32),
            Font     = new Font("Segoe UI", 13f),
        };
    }

    private static Button MakeActionButton(string text, int x, int y, Color? color = null)
    {
        var c = color ?? Color.FromArgb(30, 102, 245);
        return new Button
        {
            Text      = text,
            Location  = new Point(x, y),
            Size      = new Size(168, 40),
            FlatStyle = FlatStyle.Flat,
            BackColor = c,
            ForeColor = Color.White,
            Font      = new Font("Segoe UI", 12f, FontStyle.Bold),
            Cursor    = Cursors.Hand,
        };
    }

    private static Button MakeClearButton(int x, int y)
    {
        return new Button
        {
            Text      = "Clear",
            Location  = new Point(x, y),
            Size      = new Size(90, 40),
            FlatStyle = FlatStyle.Flat,
            BackColor = Color.FromArgb(175, 175, 195),
            ForeColor = Color.FromArgb(30, 30, 46),
            Font      = new Font("Segoe UI", 12f),
            Cursor    = Cursors.Hand,
        };
    }

    private static Label MakeResult(int x, int y, int w = 520)
    {
        return new Label
        {
            Text      = "—",
            Location  = new Point(x, y),
            Size      = new Size(w, 36),
            Font      = new Font("Segoe UI", 14f, FontStyle.Bold),
            ForeColor = Color.FromArgb(40, 160, 100),
            AutoSize  = false,
        };
    }

    private static Panel MakeCard(int x, int y, int w, int h)
    {
        return new Panel
        {
            Location    = new Point(x, y),
            Size        = new Size(w, h),
            BackColor   = Color.White,
            BorderStyle = BorderStyle.None,
        };
    }

    private static Label MakeNote(string text)
    {
        return new Label
        {
            Text      = text,
            Font      = new Font("Segoe UI", 10.5f, FontStyle.Italic),
            ForeColor = Color.FromArgb(120, 120, 160),
            Location  = new Point(12, 14),
            Size      = new Size(800, 22),
        };
    }

    // ================================================================
    //  PANEL 1 — Basic Try-Catch: Temperature Converter
    // ================================================================
    private Panel BuildPanel1()
    {
        var p    = new Panel { BackColor = Color.Transparent };
        var card = MakeCard(0, 72, 830, 200);

        var lblF = MakeLabel("Fahrenheit:", 10, 22, 120);
        txtFahrenheit = MakeTextBox(138, 20, 170);

        btnConvert      = MakeActionButton("Convert", 138, 68);
        btnClearConvert = MakeClearButton(316, 68);
        btnConvert.Click      += btnConvert_Click;
        btnClearConvert.Click += btnClearConvert_Click;

        var lblCL = MakeLabel("Celsius:", 10, 124, 120);
        lblCelsiusResult = MakeResult(138, 120, 320);

        card.Controls.AddRange(new Control[] {
            lblF, txtFahrenheit, btnConvert, btnClearConvert, lblCL, lblCelsiusResult });

        p.Controls.AddRange(new Control[] {
            MakeTitle("💥  Try-Catch — Temperature Converter"),
            MakeInfo("Demonstrates: single catch (FormatException), ex.Message, .Focus()"),
            card });
        return p;
    }

    // ================================================================
    //  PANEL 2 — Multiple Catch: Rate Calculator
    // ================================================================
    private Panel BuildPanel2()
    {
        var p    = new Panel { BackColor = Color.Transparent };
        var card = MakeCard(0, 72, 830, 230);

        card.Controls.Add(MakeNote(
            "Try:  \"abc\" → FormatException   |   \"0.00000001\" → may Overflow   |   \"5.5\" → success"));

        var lblR = MakeLabel("Rate:", 10, 52, 80);
        txtRate  = MakeTextBox(98, 50, 170);

        btnCalcRate  = MakeActionButton("Calculate", 98, 100);
        btnClearRate = MakeClearButton(278, 100);
        btnCalcRate.Click  += btnCalcRate_Click;
        btnClearRate.Click += btnClearRate_Click;

        var lblRL = MakeLabel("Result:", 10, 156, 80);
        lblRateResult = MakeResult(98, 152, 500);

        card.Controls.AddRange(new Control[] {
            lblR, txtRate, btnCalcRate, btnClearRate, lblRL, lblRateResult });

        p.Controls.AddRange(new Control[] {
            MakeTitle("🛡️  Multiple Catch Blocks — Rate Calculator"),
            MakeInfo("Demonstrates: FormatException → OverflowException → Exception; ex.Message, ex.GetType(), ex.StackTrace"),
            card });
        return p;
    }

    // ================================================================
    //  PANEL 3 — Finally Block
    // ================================================================
    private Panel BuildPanel3()
    {
        var p    = new Panel { BackColor = Color.Transparent };
        var card = MakeCard(0, 72, 830, 260);

        chkForceError = new CheckBox
        {
            Text     = "Force an exception to be thrown",
            Font     = new Font("Segoe UI", 12.5f),
            Location = new Point(12, 18),
            Size     = new Size(380, 30),
        };

        btnRunOperation  = MakeActionButton("Run Operation", 12, 60);
        btnClearFinally  = MakeClearButton(190, 60);
        btnRunOperation.Click += btnRunOperation_Click;
        btnClearFinally.Click += btnClearFinally_Click;

        var lblOL = MakeLabel("Operation:", 12, 118, 112);
        lblFinallyResult = MakeResult(132, 114, 600);

        var lblFL = MakeLabel("Finally:", 12, 164, 112);
        lblFinallyStatus = new Label
        {
            Text      = "—",
            Location  = new Point(132, 160),
            Size      = new Size(600, 36),
            Font      = new Font("Segoe UI", 14f, FontStyle.Bold),
            ForeColor = Color.FromArgb(30, 102, 245),
        };

        card.Controls.AddRange(new Control[] {
            chkForceError, btnRunOperation, btnClearFinally,
            lblOL, lblFinallyResult, lblFL, lblFinallyStatus });

        p.Controls.AddRange(new Control[] {
            MakeTitle("🔒  Finally Block — Resource Cleanup"),
            MakeInfo("Demonstrates: finally always executes whether or not an exception was thrown — used for cleanup."),
            card });
        return p;
    }

    // ================================================================
    //  PANEL 4 — Throw Statements
    // ================================================================
    private Panel BuildPanel4()
    {
        var p    = new Panel { BackColor = Color.Transparent };
        var card = MakeCard(0, 72, 830, 300);

        var lblP = MakeLabel("Price ($):", 10, 22, 110);
        txtDiscountPrice = MakeTextBox(128, 20, 150);

        var lblPct = MakeLabel("Discount %:", 304, 22, 120);
        txtDiscountPct   = MakeTextBox(432, 20, 110);

        btnCalcDiscount  = MakeActionButton("Calc Discount", 128, 70);
        btnClearDiscount = MakeClearButton(306, 70);
        btnCalcDiscount.Click  += btnCalcDiscount_Click;
        btnClearDiscount.Click += btnClearDiscount_Click;

        var lblRL = MakeLabel("Result:", 10, 126, 110);
        lblDiscountResult = MakeResult(128, 122, 560);

        var sep = new Label
        {
            Text      = "──────────────────────────────────────────────",
            Location  = new Point(10, 172),
            Size      = new Size(800, 20),
            Font      = new Font("Segoe UI", 10f),
            ForeColor = Color.FromArgb(200, 200, 220),
        };

        var lblRethrow = new Label
        {
            Text      = "Re-Throw Demo  —  catch → log → throw;  (stack trace preserved)",
            Font      = new Font("Segoe UI", 12f, FontStyle.Bold),
            ForeColor = Color.FromArgb(50, 50, 80),
            Location  = new Point(10, 198),
            Size      = new Size(680, 28),
        };

        btnTestRethrow = MakeActionButton("Test Re-Throw", 10, 234, Color.FromArgb(107, 61, 173));
        btnTestRethrow.Click += btnTestRethrow_Click;

        card.Controls.AddRange(new Control[] {
            lblP, txtDiscountPrice, lblPct, txtDiscountPct,
            btnCalcDiscount, btnClearDiscount,
            lblRL, lblDiscountResult,
            sep, lblRethrow, btnTestRethrow });

        p.Controls.AddRange(new Control[] {
            MakeTitle("🚀  Throw Statements — Discount Calculator"),
            MakeInfo("Demonstrates: throw new ArgumentException(), re-throw with throw; (preserves stack trace vs throw ex;)"),
            card });
        return p;
    }

    // ================================================================
    //  PANEL 5 — MessageBox & DialogResult
    // ================================================================
    private Panel BuildPanel5()
    {
        var p    = new Panel { BackColor = Color.Transparent };
        var card = MakeCard(0, 72, 830, 330);

        int bx = 12, by = 16, gap = 56;

        btnShowSimple = MakeActionButton("Simple Message",    bx, by,          Color.FromArgb(80, 120, 200));
        btnShowTitled = MakeActionButton("Message + Title",   bx, by + gap,     Color.FromArgb(80, 120, 200));
        btnShowYesNo  = MakeActionButton("YesNo + Question",  bx, by + gap * 2, Color.FromArgb(30, 102, 245));
        btnShowWarning= MakeActionButton("Warning Icon",      bx, by + gap * 3, Color.FromArgb(210, 120, 20));
        btnShowError  = MakeActionButton("Error Icon",        bx, by + gap * 4, Color.FromArgb(190, 40, 40));

        btnShowSimple.Click  += btnShowSimple_Click;
        btnShowTitled.Click  += btnShowTitled_Click;
        btnShowYesNo.Click   += btnShowYesNo_Click;
        btnShowWarning.Click += btnShowWarning_Click;
        btnShowError.Click   += btnShowError_Click;

        var lblRL = new Label
        {
            Text      = "Last DialogResult:",
            Font      = new Font("Segoe UI", 12f, FontStyle.Bold),
            ForeColor = Color.FromArgb(50, 50, 80),
            Location  = new Point(218, 16),
            Size      = new Size(220, 28),
        };

        lblDialogResult = new Label
        {
            Text      = "—",
            Location  = new Point(218, 48),
            Size      = new Size(580, 220),
            Font      = new Font("Segoe UI", 13f),
            ForeColor = Color.FromArgb(30, 102, 245),
        };

        card.Controls.AddRange(new Control[] {
            btnShowSimple, btnShowTitled, btnShowYesNo,
            btnShowWarning, btnShowError, lblRL, lblDialogResult });

        p.Controls.AddRange(new Control[] {
            MakeTitle("💬  MessageBox.Show() — DialogResult Demo"),
            MakeInfo("Demonstrates: MessageBoxButtons, MessageBoxIcon, reading DialogResult from Show()"),
            card });
        return p;
    }

    // ================================================================
    //  PANEL 6 — Inline Validation
    // ================================================================
    private Panel BuildPanel6()
    {
        var p    = new Panel { BackColor = Color.Transparent };
        var card = MakeCard(0, 72, 830, 240);

        card.Controls.Add(MakeNote(
            "Quantity must be a whole number 1 – 100.   Unit price: $19.99 (fixed)."));

        var lblQ = MakeLabel("Quantity:", 10, 52, 100);
        txtInlineQty  = MakeTextBox(118, 50, 150);

        btnCalcOrder  = MakeActionButton("Calculate Total", 118, 102);
        btnClearOrder = MakeClearButton(296, 102);
        btnCalcOrder.Click  += btnCalcOrder_Click;
        btnClearOrder.Click += btnClearOrder_Click;

        var lblTL = MakeLabel("Total:", 10, 160, 100);
        lblOrderTotal  = MakeResult(118, 156, 500);

        card.Controls.AddRange(new Control[] {
            lblQ, txtInlineQty, btnCalcOrder, btnClearOrder, lblTL, lblOrderTotal });

        p.Controls.AddRange(new Control[] {
            MakeTitle("✅  Inline Data Validation — Order Calculator"),
            MakeInfo("Demonstrates: presence check → TryParse type check → range check, all inline in the click handler"),
            card });
        return p;
    }

    // ================================================================
    //  PANEL 7 — Generic Validation Methods
    // ================================================================
    private Panel BuildPanel7()
    {
        var p    = new Panel { BackColor = Color.Transparent };
        var card = MakeCard(0, 72, 830, 310);

        card.Controls.Add(MakeNote(
            "Price: $0.01 – $9,999.99   |   Quantity: 1 – 100 (integer)   |   Generic methods + outer try-catch safety net"));

        var lblPR = MakeLabel("Price ($):", 10, 52, 100);
        txtGenericPrice = MakeTextBox(118, 50, 160);

        var lblQT = MakeLabel("Quantity:", 312, 52, 100);
        txtGenericQty = MakeTextBox(420, 50, 120);

        btnCalcGeneric  = MakeActionButton("Calculate Total", 118, 106);
        btnClearGeneric = MakeClearButton(296, 106);
        btnCalcGeneric.Click  += btnCalcGeneric_Click;
        btnClearGeneric.Click += btnClearGeneric_Click;

        var lblTL = MakeLabel("Total:", 10, 164, 100);
        lblGenericTotal = MakeResult(118, 160, 500);

        var infoBox = new Panel
        {
            Location  = new Point(10, 212),
            Size      = new Size(800, 72),
            BackColor = Color.FromArgb(232, 238, 255),
        };
        infoBox.Controls.Add(new Label
        {
            Text      = "IsValidData() → IsPresent() → IsDecimal() / IsInt() → IsWithinRange()  (sequential, early-return)\n" +
                        "AND-chain variant using && shown in code comments — both use short-circuit evaluation.",
            Font      = new Font("Segoe UI", 10.5f, FontStyle.Italic),
            ForeColor = Color.FromArgb(50, 60, 120),
            Location  = new Point(10, 8),
            Size      = new Size(780, 56),
        });

        card.Controls.AddRange(new Control[] {
            lblPR, txtGenericPrice, lblQT, txtGenericQty,
            btnCalcGeneric, btnClearGeneric,
            lblTL, lblGenericTotal, infoBox });

        p.Controls.AddRange(new Control[] {
            MakeTitle("♻️  Generic Validation Methods — Two-Layer Defense"),
            MakeInfo("Demonstrates: IsPresent(), IsDecimal(), IsInt(), IsWithinRange(), IsValidData() + try-catch safety net"),
            card });
        return p;
    }

    // ================================================================
    //  PANEL 8 — TryParse vs Convert
    // ================================================================
    private Panel BuildPanel8()
    {
        var p    = new Panel { BackColor = Color.Transparent };
        var card = MakeCard(0, 72, 830, 300);

        card.Controls.Add(MakeNote(
            "Try:  a valid number (\"42.5\")   |   invalid text (\"hello\")   |   empty string"));

        var lblIn = MakeLabel("Input:", 10, 52, 80);
        txtTryParseInput = MakeTextBox(98, 50, 190);

        btnTryParseDemo  = MakeActionButton("Run Comparison", 98, 104);
        btnClearTryParse = MakeClearButton(276, 104);
        btnTryParseDemo.Click  += btnTryParseDemo_Click;
        btnClearTryParse.Click += btnClearTryParse_Click;

        var lblTP = new Label
        {
            Text      = "decimal.TryParse():",
            Font      = new Font("Segoe UI", 13f, FontStyle.Bold),
            ForeColor = Color.FromArgb(30, 102, 245),
            Location  = new Point(10, 164),
            Size      = new Size(260, 28),
        };
        lblTryParseResult = new Label
        {
            Text      = "—",
            Location  = new Point(10, 194),
            Size      = new Size(800, 30),
            Font      = new Font("Segoe UI", 13f),
        };

        var lblCv = new Label
        {
            Text      = "Convert.ToDecimal():",
            Font      = new Font("Segoe UI", 13f, FontStyle.Bold),
            ForeColor = Color.FromArgb(190, 40, 40),
            Location  = new Point(10, 234),
            Size      = new Size(280, 28),
        };
        lblConvertResult = new Label
        {
            Text      = "—",
            Location  = new Point(10, 264),
            Size      = new Size(800, 30),
            Font      = new Font("Segoe UI", 13f),
        };

        card.Controls.AddRange(new Control[] {
            lblIn, txtTryParseInput,
            btnTryParseDemo, btnClearTryParse,
            lblTP, lblTryParseResult,
            lblCv, lblConvertResult });

        p.Controls.AddRange(new Control[] {
            MakeTitle("🔄  TryParse vs Convert — Side-by-Side"),
            MakeInfo("Demonstrates: TryParse returns bool (no exception thrown) vs Convert throws FormatException on failure"),
            card });
        return p;
    }

    #endregion

    // ---- Layout containers ----
    private Panel pnlSidebar, pnlContent, pnlHeader;
    private Label lblHeader, lblSubHeader;

    // ---- Nav buttons ----
    private Button btnNav1, btnNav2, btnNav3, btnNav4;
    private Button btnNav5, btnNav6, btnNav7, btnNav8;

    // ---- Content panels ----
    private Panel pnl1, pnl2, pnl3, pnl4, pnl5, pnl6, pnl7, pnl8;

    // ---- Panel 1 ----
    private TextBox txtFahrenheit = null!;
    private Button  btnConvert = null!, btnClearConvert = null!;
    private Label   lblCelsiusResult = null!;

    // ---- Panel 2 ----
    private TextBox txtRate = null!;
    private Button  btnCalcRate = null!, btnClearRate = null!;
    private Label   lblRateResult = null!;

    // ---- Panel 3 ----
    private CheckBox chkForceError = null!;
    private Button   btnRunOperation = null!, btnClearFinally = null!;
    private Label    lblFinallyResult = null!, lblFinallyStatus = null!;

    // ---- Panel 4 ----
    private TextBox txtDiscountPrice = null!, txtDiscountPct = null!;
    private Button  btnCalcDiscount = null!, btnClearDiscount = null!, btnTestRethrow = null!;
    private Label   lblDiscountResult = null!;

    // ---- Panel 5 ----
    private Button btnShowSimple = null!, btnShowTitled = null!, btnShowYesNo = null!;
    private Button btnShowWarning = null!, btnShowError = null!;
    private Label  lblDialogResult = null!;

    // ---- Panel 6 ----
    private TextBox txtInlineQty = null!;
    private Button  btnCalcOrder = null!, btnClearOrder = null!;
    private Label   lblOrderTotal = null!;

    // ---- Panel 7 ----
    private TextBox txtGenericPrice = null!, txtGenericQty = null!;
    private Button  btnCalcGeneric = null!, btnClearGeneric = null!;
    private Label   lblGenericTotal = null!;

    // ---- Panel 8 ----
    private TextBox txtTryParseInput = null!;
    private Button  btnTryParseDemo = null!, btnClearTryParse = null!;
    private Label   lblTryParseResult = null!, lblConvertResult = null!;
}
