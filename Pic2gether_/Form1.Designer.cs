
namespace Pic2gether_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChColor = new System.Windows.Forms.ColorDialog();
            this.BColore = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bVisibility = new System.Windows.Forms.Button();
            this.bLine = new System.Windows.Forms.Button();
            this.bRectangle = new System.Windows.Forms.Button();
            this.bCircle = new System.Windows.Forms.Button();
            this.bSquare = new System.Windows.Forms.Button();
            this.bEllipse = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.BColorLil = new System.Windows.Forms.Button();
            this.NText = new System.Windows.Forms.Label();
            this.BText = new System.Windows.Forms.Button();
            this.NErase = new System.Windows.Forms.Label();
            this.BErase = new System.Windows.Forms.Button();
            this.NPen = new System.Windows.Forms.Label();
            this.BPen = new System.Windows.Forms.Button();
            this.NFill = new System.Windows.Forms.Label();
            this.BFill = new System.Windows.Forms.Button();
            this.NColor = new System.Windows.Forms.Label();
            this.ZoomPanel = new System.Windows.Forms.Panel();
            this.Canva = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Canva)).BeginInit();
            this.SuspendLayout();
            // 
            // BColore
            // 
            this.BColore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BColore.Location = new System.Drawing.Point(13, 10);
            this.BColore.Name = "BColore";
            this.BColore.Size = new System.Drawing.Size(40, 40);
            this.BColore.TabIndex = 0;
            this.BColore.UseVisualStyleBackColor = false;
            this.BColore.Click += new System.EventHandler(this.ColorChange);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.bVisibility);
            this.splitContainer1.Panel1.Controls.Add(this.bLine);
            this.splitContainer1.Panel1.Controls.Add(this.bRectangle);
            this.splitContainer1.Panel1.Controls.Add(this.bCircle);
            this.splitContainer1.Panel1.Controls.Add(this.bSquare);
            this.splitContainer1.Panel1.Controls.Add(this.bEllipse);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bClear);
            this.splitContainer1.Panel2.Controls.Add(this.bSave);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox2);
            this.splitContainer1.Panel2.Controls.Add(this.BColorLil);
            this.splitContainer1.Panel2.Controls.Add(this.NText);
            this.splitContainer1.Panel2.Controls.Add(this.BText);
            this.splitContainer1.Panel2.Controls.Add(this.NErase);
            this.splitContainer1.Panel2.Controls.Add(this.BErase);
            this.splitContainer1.Panel2.Controls.Add(this.NPen);
            this.splitContainer1.Panel2.Controls.Add(this.BPen);
            this.splitContainer1.Panel2.Controls.Add(this.NFill);
            this.splitContainer1.Panel2.Controls.Add(this.BFill);
            this.splitContainer1.Panel2.Controls.Add(this.NColor);
            this.splitContainer1.Panel2.Controls.Add(this.BColore);
            this.splitContainer1.Size = new System.Drawing.Size(1143, 73);
            this.splitContainer1.SplitterDistance = 523;
            this.splitContainer1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Прозрачность",
            "Заливка"});
            this.comboBox1.Location = new System.Drawing.Point(417, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bVisibility
            // 
            this.bVisibility.BackgroundImage = global::Pic2gether_.Properties.Resources.visibility;
            this.bVisibility.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bVisibility.Enabled = false;
            this.bVisibility.Location = new System.Drawing.Point(417, 20);
            this.bVisibility.Name = "bVisibility";
            this.bVisibility.Size = new System.Drawing.Size(20, 20);
            this.bVisibility.TabIndex = 19;
            this.bVisibility.UseVisualStyleBackColor = true;
            // 
            // bLine
            // 
            this.bLine.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bLine.BackgroundImage = global::Pic2gether_.Properties.Resources.Line;
            this.bLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bLine.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bLine.Location = new System.Drawing.Point(354, 10);
            this.bLine.Name = "bLine";
            this.bLine.Size = new System.Drawing.Size(40, 40);
            this.bLine.TabIndex = 17;
            this.bLine.UseVisualStyleBackColor = false;
            this.bLine.Click += new System.EventHandler(this.bLine_Click);
            // 
            // bRectangle
            // 
            this.bRectangle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bRectangle.BackgroundImage = global::Pic2gether_.Properties.Resources.Rectangle;
            this.bRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bRectangle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bRectangle.Location = new System.Drawing.Point(288, 10);
            this.bRectangle.Name = "bRectangle";
            this.bRectangle.Size = new System.Drawing.Size(40, 40);
            this.bRectangle.TabIndex = 16;
            this.bRectangle.UseVisualStyleBackColor = false;
            this.bRectangle.Click += new System.EventHandler(this.bRectangle_Click);
            // 
            // bCircle
            // 
            this.bCircle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bCircle.BackgroundImage = global::Pic2gether_.Properties.Resources.Circle;
            this.bCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCircle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bCircle.Location = new System.Drawing.Point(157, 10);
            this.bCircle.Name = "bCircle";
            this.bCircle.Size = new System.Drawing.Size(40, 40);
            this.bCircle.TabIndex = 15;
            this.bCircle.UseVisualStyleBackColor = false;
            this.bCircle.Click += new System.EventHandler(this.bCircle_Click);
            // 
            // bSquare
            // 
            this.bSquare.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bSquare.BackgroundImage = global::Pic2gether_.Properties.Resources.Square;
            this.bSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bSquare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSquare.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bSquare.Location = new System.Drawing.Point(223, 10);
            this.bSquare.Name = "bSquare";
            this.bSquare.Size = new System.Drawing.Size(40, 40);
            this.bSquare.TabIndex = 14;
            this.bSquare.UseVisualStyleBackColor = false;
            this.bSquare.Click += new System.EventHandler(this.bSquare_Click);
            // 
            // bEllipse
            // 
            this.bEllipse.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bEllipse.BackgroundImage = global::Pic2gether_.Properties.Resources.Ellipse;
            this.bEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bEllipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEllipse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bEllipse.Location = new System.Drawing.Point(84, 10);
            this.bEllipse.Name = "bEllipse";
            this.bEllipse.Size = new System.Drawing.Size(40, 40);
            this.bEllipse.TabIndex = 13;
            this.bEllipse.UseVisualStyleBackColor = false;
            this.bEllipse.Click += new System.EventHandler(this.bEllipse_Click);
            // 
            // bClear
            // 
            this.bClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bClear.Location = new System.Drawing.Point(489, 38);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(114, 22);
            this.bClear.TabIndex = 17;
            this.bClear.Text = "Очистить";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bSave
            // 
            this.bSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bSave.Location = new System.Drawing.Point(489, 10);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(114, 22);
            this.bSave.TabIndex = 16;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(351, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 22);
            this.button1.TabIndex = 15;
            this.button1.Text = "Толщина линии";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1 px",
            "2 px",
            "3 px",
            "5 px",
            "7 px",
            "10 px",
            "20 px",
            "30 px",
            "40 px",
            "50 px",
            "100 px",
            "200 px"});
            this.comboBox2.Location = new System.Drawing.Point(351, 45);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // BColorLil
            // 
            this.BColorLil.BackColor = System.Drawing.Color.White;
            this.BColorLil.Location = new System.Drawing.Point(55, 30);
            this.BColorLil.Name = "BColorLil";
            this.BColorLil.Size = new System.Drawing.Size(20, 20);
            this.BColorLil.TabIndex = 12;
            this.BColorLil.UseVisualStyleBackColor = false;
            this.BColorLil.Click += new System.EventHandler(this.BColorLilChange);
            // 
            // NText
            // 
            this.NText.AutoSize = true;
            this.NText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NText.Location = new System.Drawing.Point(283, 53);
            this.NText.Name = "NText";
            this.NText.Size = new System.Drawing.Size(37, 13);
            this.NText.TabIndex = 11;
            this.NText.Text = "Текст";
            this.NText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BText
            // 
            this.BText.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BText.BackgroundImage = global::Pic2gether_.Properties.Resources.Text;
            this.BText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BText.Enabled = false;
            this.BText.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BText.Location = new System.Drawing.Point(281, 10);
            this.BText.Name = "BText";
            this.BText.Size = new System.Drawing.Size(40, 40);
            this.BText.TabIndex = 10;
            this.BText.UseVisualStyleBackColor = false;
            // 
            // NErase
            // 
            this.NErase.AutoSize = true;
            this.NErase.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NErase.Location = new System.Drawing.Point(224, 53);
            this.NErase.Name = "NErase";
            this.NErase.Size = new System.Drawing.Size(44, 13);
            this.NErase.TabIndex = 7;
            this.NErase.Text = "Ластик";
            this.NErase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BErase
            // 
            this.BErase.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BErase.BackgroundImage = global::Pic2gether_.Properties.Resources.Erase;
            this.BErase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BErase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BErase.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BErase.Location = new System.Drawing.Point(226, 10);
            this.BErase.Name = "BErase";
            this.BErase.Size = new System.Drawing.Size(40, 40);
            this.BErase.TabIndex = 6;
            this.BErase.UseVisualStyleBackColor = false;
            this.BErase.Click += new System.EventHandler(this.BErase_Click);
            // 
            // NPen
            // 
            this.NPen.AutoSize = true;
            this.NPen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NPen.Location = new System.Drawing.Point(169, 53);
            this.NPen.Name = "NPen";
            this.NPen.Size = new System.Drawing.Size(36, 13);
            this.NPen.TabIndex = 5;
            this.NPen.Text = "Ручка";
            this.NPen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BPen
            // 
            this.BPen.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BPen.BackgroundImage = global::Pic2gether_.Properties.Resources.Pen;
            this.BPen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BPen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BPen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BPen.Location = new System.Drawing.Point(168, 10);
            this.BPen.Name = "BPen";
            this.BPen.Size = new System.Drawing.Size(40, 40);
            this.BPen.TabIndex = 4;
            this.BPen.UseVisualStyleBackColor = false;
            this.BPen.Click += new System.EventHandler(this.BPen_Click);
            // 
            // NFill
            // 
            this.NFill.AutoSize = true;
            this.NFill.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NFill.Location = new System.Drawing.Point(102, 53);
            this.NFill.Name = "NFill";
            this.NFill.Size = new System.Drawing.Size(50, 13);
            this.NFill.TabIndex = 3;
            this.NFill.Text = "Заливка";
            this.NFill.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BFill
            // 
            this.BFill.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BFill.BackgroundImage = global::Pic2gether_.Properties.Resources.Fill1;
            this.BFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BFill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BFill.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BFill.Location = new System.Drawing.Point(106, 10);
            this.BFill.Name = "BFill";
            this.BFill.Size = new System.Drawing.Size(40, 40);
            this.BFill.TabIndex = 2;
            this.BFill.UseVisualStyleBackColor = false;
            this.BFill.Click += new System.EventHandler(this.BFill_Click);
            // 
            // NColor
            // 
            this.NColor.AutoSize = true;
            this.NColor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NColor.Location = new System.Drawing.Point(17, 53);
            this.NColor.Name = "NColor";
            this.NColor.Size = new System.Drawing.Size(32, 13);
            this.NColor.TabIndex = 1;
            this.NColor.Text = "Цвет";
            this.NColor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ZoomPanel
            // 
            this.ZoomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ZoomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ZoomPanel.Location = new System.Drawing.Point(0, 564);
            this.ZoomPanel.Name = "ZoomPanel";
            this.ZoomPanel.Size = new System.Drawing.Size(1143, 20);
            this.ZoomPanel.TabIndex = 2;
            this.ZoomPanel.UseWaitCursor = true;
            // 
            // Canva
            // 
            this.Canva.BackColor = System.Drawing.Color.DimGray;
            this.Canva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canva.Location = new System.Drawing.Point(0, 0);
            this.Canva.Name = "Canva";
            this.Canva.Size = new System.Drawing.Size(1143, 584);
            this.Canva.TabIndex = 0;
            this.Canva.TabStop = false;
            this.Canva.Paint += new System.Windows.Forms.PaintEventHandler(this.Canva_Paint);
            this.Canva.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Canva_MouseClick);
            this.Canva.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canva_MouseDown);
            this.Canva.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canva_MouseMove);
            this.Canva.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canva_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1143, 584);
            this.Controls.Add(this.ZoomPanel);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Canva);
            this.Name = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Canva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog ChColor;
        private System.Windows.Forms.Button BColore;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label NColor;
        private System.Windows.Forms.PictureBox Canva;
        private System.Windows.Forms.Panel ZoomPanel;
        private System.Windows.Forms.Button BFill;
        private System.Windows.Forms.Label NFill;
        private System.Windows.Forms.Button BPen;
        private System.Windows.Forms.Label NErase;
        private System.Windows.Forms.Button BErase;
        private System.Windows.Forms.Label NPen;
        private System.Windows.Forms.Label NText;
        private System.Windows.Forms.Button BText;
        private System.Windows.Forms.Button BColorLil;
        private System.Windows.Forms.Button bLine;
        private System.Windows.Forms.Button bRectangle;
        private System.Windows.Forms.Button bCircle;
        private System.Windows.Forms.Button bSquare;
        private System.Windows.Forms.Button bEllipse;
        private System.Windows.Forms.Button bVisibility;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bSave;
    }
}

