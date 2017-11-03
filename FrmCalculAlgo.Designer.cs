namespace CalculAlgo
{
    partial class FrmCalculAlgo
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalculAlgo));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.ImgComb = new System.Windows.Forms.PictureBox();
			this.LbCombN = new System.Windows.Forms.Label();
			this.TxtKValComb = new System.Windows.Forms.TextBox();
			this.TxtNValComb = new System.Windows.Forms.TextBox();
			this.LbCombK = new System.Windows.Forms.Label();
			this.BtnCombCalc = new System.Windows.Forms.Button();
			this.TxtResultComb = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.ImgArr = new System.Windows.Forms.PictureBox();
			this.LbArrN = new System.Windows.Forms.Label();
			this.TxtKValArr = new System.Windows.Forms.TextBox();
			this.TxtNValArr = new System.Windows.Forms.TextBox();
			this.LbArrK = new System.Windows.Forms.Label();
			this.BtnArrCalc = new System.Windows.Forms.Button();
			this.TxtResultArr = new System.Windows.Forms.TextBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.RdBtnBinoEgal = new System.Windows.Forms.RadioButton();
			this.RdBtnBinoSupEgal = new System.Windows.Forms.RadioButton();
			this.RdBtnBinoInfEgal = new System.Windows.Forms.RadioButton();
			this.RdBtnBinoSup = new System.Windows.Forms.RadioButton();
			this.RdBtnBinoInf = new System.Windows.Forms.RadioButton();
			this.BtnBinoClear = new System.Windows.Forms.Button();
			this.TxtResultBino = new System.Windows.Forms.RichTextBox();
			this.TxtPValBino = new System.Windows.Forms.TextBox();
			this.LbBinoP = new System.Windows.Forms.Label();
			this.LbBinoN = new System.Windows.Forms.Label();
			this.TxtKValBino = new System.Windows.Forms.TextBox();
			this.TxtNValBino = new System.Windows.Forms.TextBox();
			this.LbBinoK = new System.Windows.Forms.Label();
			this.BtnBinoCalc = new System.Windows.Forms.Button();
			this.ImgBino = new System.Windows.Forms.PictureBox();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.RdBtnPoissEgal = new System.Windows.Forms.RadioButton();
			this.RdBtnPoissInfEgal = new System.Windows.Forms.RadioButton();
			this.RdBtnPoissInf = new System.Windows.Forms.RadioButton();
			this.BtnPoissonClear = new System.Windows.Forms.Button();
			this.TxtResultPoiss = new System.Windows.Forms.RichTextBox();
			this.LbPoisLamb = new System.Windows.Forms.Label();
			this.TxtPoissonKVal = new System.Windows.Forms.TextBox();
			this.TxtPoissonLambdaVal = new System.Windows.Forms.TextBox();
			this.LbPoissK = new System.Windows.Forms.Label();
			this.BtnPoissonCalc = new System.Windows.Forms.Button();
			this.ImgPoiss = new System.Windows.Forms.PictureBox();
			this.tabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ImgComb)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ImgArr)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ImgBino)).BeginInit();
			this.tabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ImgPoiss)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.TabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(902, 1010);
			this.tabControl1.TabIndex = 8;
			// 
			// TabPage1
			// 
			this.TabPage1.Controls.Add(this.ImgComb);
			this.TabPage1.Controls.Add(this.LbCombN);
			this.TabPage1.Controls.Add(this.TxtKValComb);
			this.TabPage1.Controls.Add(this.TxtNValComb);
			this.TabPage1.Controls.Add(this.LbCombK);
			this.TabPage1.Controls.Add(this.BtnCombCalc);
			this.TabPage1.Controls.Add(this.TxtResultComb);
			this.TabPage1.Location = new System.Drawing.Point(8, 39);
			this.TabPage1.Margin = new System.Windows.Forms.Padding(4);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Padding = new System.Windows.Forms.Padding(4);
			this.TabPage1.Size = new System.Drawing.Size(886, 963);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "Combinaisons";
			this.TabPage1.UseVisualStyleBackColor = true;
			// 
			// ImgComb
			// 
			this.ImgComb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ImgComb.Image = global::CalculAlgo.Properties.Resources.Facto;
			this.ImgComb.ImageLocation = "";
			this.ImgComb.Location = new System.Drawing.Point(82, 60);
			this.ImgComb.Margin = new System.Windows.Forms.Padding(4);
			this.ImgComb.Name = "ImgComb";
			this.ImgComb.Size = new System.Drawing.Size(752, 308);
			this.ImgComb.TabIndex = 7;
			this.ImgComb.TabStop = false;
			// 
			// LbCombN
			// 
			this.LbCombN.AutoSize = true;
			this.LbCombN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LbCombN.Location = new System.Drawing.Point(76, 412);
			this.LbCombN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LbCombN.Name = "LbCombN";
			this.LbCombN.Size = new System.Drawing.Size(209, 42);
			this.LbCombN.TabIndex = 1;
			this.LbCombN.Text = "Valeur de n";
			// 
			// TxtKValComb
			// 
			this.TxtKValComb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtKValComb.Location = new System.Drawing.Point(293, 466);
			this.TxtKValComb.Margin = new System.Windows.Forms.Padding(4);
			this.TxtKValComb.Name = "TxtKValComb";
			this.TxtKValComb.Size = new System.Drawing.Size(180, 49);
			this.TxtKValComb.TabIndex = 6;
			// 
			// TxtNValComb
			// 
			this.TxtNValComb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtNValComb.Location = new System.Drawing.Point(293, 409);
			this.TxtNValComb.Margin = new System.Windows.Forms.Padding(4);
			this.TxtNValComb.Name = "TxtNValComb";
			this.TxtNValComb.Size = new System.Drawing.Size(180, 49);
			this.TxtNValComb.TabIndex = 2;
			// 
			// LbCombK
			// 
			this.LbCombK.AutoSize = true;
			this.LbCombK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LbCombK.Location = new System.Drawing.Point(76, 477);
			this.LbCombK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LbCombK.Name = "LbCombK";
			this.LbCombK.Size = new System.Drawing.Size(207, 42);
			this.LbCombK.TabIndex = 5;
			this.LbCombK.Text = "Valeur de k";
			// 
			// BtnCombCalc
			// 
			this.BtnCombCalc.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnCombCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnCombCalc.Location = new System.Drawing.Point(616, 410);
			this.BtnCombCalc.Margin = new System.Windows.Forms.Padding(4);
			this.BtnCombCalc.Name = "BtnCombCalc";
			this.BtnCombCalc.Size = new System.Drawing.Size(218, 113);
			this.BtnCombCalc.TabIndex = 3;
			this.BtnCombCalc.Text = "Calculer";
			this.BtnCombCalc.UseVisualStyleBackColor = true;
			this.BtnCombCalc.Click += new System.EventHandler(this.BtnCombCalc_Click);
			// 
			// TxtResultComb
			// 
			this.TxtResultComb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtResultComb.Location = new System.Drawing.Point(82, 552);
			this.TxtResultComb.Margin = new System.Windows.Forms.Padding(4);
			this.TxtResultComb.Name = "TxtResultComb";
			this.TxtResultComb.ReadOnly = true;
			this.TxtResultComb.Size = new System.Drawing.Size(752, 50);
			this.TxtResultComb.TabIndex = 4;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.ImgArr);
			this.tabPage2.Controls.Add(this.LbArrN);
			this.tabPage2.Controls.Add(this.TxtKValArr);
			this.tabPage2.Controls.Add(this.TxtNValArr);
			this.tabPage2.Controls.Add(this.LbArrK);
			this.tabPage2.Controls.Add(this.BtnArrCalc);
			this.tabPage2.Controls.Add(this.TxtResultArr);
			this.tabPage2.Location = new System.Drawing.Point(8, 39);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage2.Size = new System.Drawing.Size(886, 963);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Arrangements";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// ImgArr
			// 
			this.ImgArr.Image = global::CalculAlgo.Properties.Resources.Arrangement;
			this.ImgArr.Location = new System.Drawing.Point(78, 71);
			this.ImgArr.Margin = new System.Windows.Forms.Padding(4);
			this.ImgArr.Name = "ImgArr";
			this.ImgArr.Size = new System.Drawing.Size(752, 302);
			this.ImgArr.TabIndex = 13;
			this.ImgArr.TabStop = false;
			// 
			// LbArrN
			// 
			this.LbArrN.AutoSize = true;
			this.LbArrN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LbArrN.Location = new System.Drawing.Point(72, 456);
			this.LbArrN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LbArrN.Name = "LbArrN";
			this.LbArrN.Size = new System.Drawing.Size(209, 42);
			this.LbArrN.TabIndex = 7;
			this.LbArrN.Text = "Valeur de n";
			// 
			// TxtKValArr
			// 
			this.TxtKValArr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtKValArr.Location = new System.Drawing.Point(368, 517);
			this.TxtKValArr.Margin = new System.Windows.Forms.Padding(4);
			this.TxtKValArr.Name = "TxtKValArr";
			this.TxtKValArr.Size = new System.Drawing.Size(180, 49);
			this.TxtKValArr.TabIndex = 12;
			// 
			// TxtNValArr
			// 
			this.TxtNValArr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtNValArr.Location = new System.Drawing.Point(368, 452);
			this.TxtNValArr.Margin = new System.Windows.Forms.Padding(4);
			this.TxtNValArr.Name = "TxtNValArr";
			this.TxtNValArr.Size = new System.Drawing.Size(180, 49);
			this.TxtNValArr.TabIndex = 8;
			// 
			// LbArrK
			// 
			this.LbArrK.AutoSize = true;
			this.LbArrK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LbArrK.Location = new System.Drawing.Point(72, 519);
			this.LbArrK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LbArrK.Name = "LbArrK";
			this.LbArrK.Size = new System.Drawing.Size(207, 42);
			this.LbArrK.TabIndex = 11;
			this.LbArrK.Text = "Valeur de k";
			// 
			// BtnArrCalc
			// 
			this.BtnArrCalc.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnArrCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnArrCalc.Location = new System.Drawing.Point(612, 452);
			this.BtnArrCalc.Margin = new System.Windows.Forms.Padding(4);
			this.BtnArrCalc.Name = "BtnArrCalc";
			this.BtnArrCalc.Size = new System.Drawing.Size(218, 113);
			this.BtnArrCalc.TabIndex = 9;
			this.BtnArrCalc.Text = "Calculer";
			this.BtnArrCalc.UseVisualStyleBackColor = true;
			this.BtnArrCalc.Click += new System.EventHandler(this.BtnArrCalc_Click);
			// 
			// TxtResultArr
			// 
			this.TxtResultArr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtResultArr.Location = new System.Drawing.Point(78, 633);
			this.TxtResultArr.Margin = new System.Windows.Forms.Padding(4);
			this.TxtResultArr.Name = "TxtResultArr";
			this.TxtResultArr.ReadOnly = true;
			this.TxtResultArr.Size = new System.Drawing.Size(752, 49);
			this.TxtResultArr.TabIndex = 10;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.RdBtnBinoEgal);
			this.tabPage3.Controls.Add(this.RdBtnBinoSupEgal);
			this.tabPage3.Controls.Add(this.RdBtnBinoInfEgal);
			this.tabPage3.Controls.Add(this.RdBtnBinoSup);
			this.tabPage3.Controls.Add(this.RdBtnBinoInf);
			this.tabPage3.Controls.Add(this.BtnBinoClear);
			this.tabPage3.Controls.Add(this.TxtResultBino);
			this.tabPage3.Controls.Add(this.TxtPValBino);
			this.tabPage3.Controls.Add(this.LbBinoP);
			this.tabPage3.Controls.Add(this.LbBinoN);
			this.tabPage3.Controls.Add(this.TxtKValBino);
			this.tabPage3.Controls.Add(this.TxtNValBino);
			this.tabPage3.Controls.Add(this.LbBinoK);
			this.tabPage3.Controls.Add(this.BtnBinoCalc);
			this.tabPage3.Controls.Add(this.ImgBino);
			this.tabPage3.Location = new System.Drawing.Point(8, 39);
			this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage3.Size = new System.Drawing.Size(886, 963);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Loi Binomiale";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// RdBtnBinoEgal
			// 
			this.RdBtnBinoEgal.AutoSize = true;
			this.RdBtnBinoEgal.Checked = true;
			this.RdBtnBinoEgal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RdBtnBinoEgal.Location = new System.Drawing.Point(21, 521);
			this.RdBtnBinoEgal.Name = "RdBtnBinoEgal";
			this.RdBtnBinoEgal.Size = new System.Drawing.Size(137, 48);
			this.RdBtnBinoEgal.TabIndex = 31;
			this.RdBtnBinoEgal.TabStop = true;
			this.RdBtnBinoEgal.Text = "X = k";
			this.RdBtnBinoEgal.UseVisualStyleBackColor = true;
			// 
			// RdBtnBinoSupEgal
			// 
			this.RdBtnBinoSupEgal.AutoSize = true;
			this.RdBtnBinoSupEgal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RdBtnBinoSupEgal.Location = new System.Drawing.Point(729, 521);
			this.RdBtnBinoSupEgal.Name = "RdBtnBinoSupEgal";
			this.RdBtnBinoSupEgal.Size = new System.Drawing.Size(137, 48);
			this.RdBtnBinoSupEgal.TabIndex = 30;
			this.RdBtnBinoSupEgal.TabStop = true;
			this.RdBtnBinoSupEgal.Text = "X ≥ k";
			this.RdBtnBinoSupEgal.UseVisualStyleBackColor = true;
			// 
			// RdBtnBinoInfEgal
			// 
			this.RdBtnBinoInfEgal.AutoSize = true;
			this.RdBtnBinoInfEgal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RdBtnBinoInfEgal.Location = new System.Drawing.Point(552, 521);
			this.RdBtnBinoInfEgal.Name = "RdBtnBinoInfEgal";
			this.RdBtnBinoInfEgal.Size = new System.Drawing.Size(137, 48);
			this.RdBtnBinoInfEgal.TabIndex = 29;
			this.RdBtnBinoInfEgal.TabStop = true;
			this.RdBtnBinoInfEgal.Text = "X ≤ k";
			this.RdBtnBinoInfEgal.UseVisualStyleBackColor = true;
			// 
			// RdBtnBinoSup
			// 
			this.RdBtnBinoSup.AutoSize = true;
			this.RdBtnBinoSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RdBtnBinoSup.Location = new System.Drawing.Point(375, 521);
			this.RdBtnBinoSup.Name = "RdBtnBinoSup";
			this.RdBtnBinoSup.Size = new System.Drawing.Size(137, 48);
			this.RdBtnBinoSup.TabIndex = 28;
			this.RdBtnBinoSup.TabStop = true;
			this.RdBtnBinoSup.Text = "X > k";
			this.RdBtnBinoSup.UseVisualStyleBackColor = true;
			// 
			// RdBtnBinoInf
			// 
			this.RdBtnBinoInf.AutoSize = true;
			this.RdBtnBinoInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RdBtnBinoInf.Location = new System.Drawing.Point(198, 521);
			this.RdBtnBinoInf.Name = "RdBtnBinoInf";
			this.RdBtnBinoInf.Size = new System.Drawing.Size(137, 48);
			this.RdBtnBinoInf.TabIndex = 27;
			this.RdBtnBinoInf.TabStop = true;
			this.RdBtnBinoInf.Text = "X < k";
			this.RdBtnBinoInf.UseVisualStyleBackColor = true;
			// 
			// BtnBinoClear
			// 
			this.BtnBinoClear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnBinoClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnBinoClear.Location = new System.Drawing.Point(667, 396);
			this.BtnBinoClear.Name = "BtnBinoClear";
			this.BtnBinoClear.Size = new System.Drawing.Size(200, 101);
			this.BtnBinoClear.TabIndex = 26;
			this.BtnBinoClear.Text = "Clear";
			this.BtnBinoClear.UseVisualStyleBackColor = true;
			this.BtnBinoClear.Click += new System.EventHandler(this.BtnBinoClear_Click);
			// 
			// TxtResultBino
			// 
			this.TxtResultBino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtResultBino.Location = new System.Drawing.Point(19, 576);
			this.TxtResultBino.Margin = new System.Windows.Forms.Padding(4);
			this.TxtResultBino.Name = "TxtResultBino";
			this.TxtResultBino.ReadOnly = true;
			this.TxtResultBino.Size = new System.Drawing.Size(848, 379);
			this.TxtResultBino.TabIndex = 23;
			this.TxtResultBino.Text = "";
			// 
			// TxtPValBino
			// 
			this.TxtPValBino.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtPValBino.Location = new System.Drawing.Point(255, 448);
			this.TxtPValBino.Margin = new System.Windows.Forms.Padding(4);
			this.TxtPValBino.Name = "TxtPValBino";
			this.TxtPValBino.Size = new System.Drawing.Size(180, 49);
			this.TxtPValBino.TabIndex = 22;
			// 
			// LbBinoP
			// 
			this.LbBinoP.AutoSize = true;
			this.LbBinoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LbBinoP.Location = new System.Drawing.Point(12, 455);
			this.LbBinoP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LbBinoP.Name = "LbBinoP";
			this.LbBinoP.Size = new System.Drawing.Size(209, 42);
			this.LbBinoP.TabIndex = 21;
			this.LbBinoP.Text = "Valeur de p";
			// 
			// LbBinoN
			// 
			this.LbBinoN.AutoSize = true;
			this.LbBinoN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LbBinoN.Location = new System.Drawing.Point(12, 341);
			this.LbBinoN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LbBinoN.Name = "LbBinoN";
			this.LbBinoN.Size = new System.Drawing.Size(209, 42);
			this.LbBinoN.TabIndex = 14;
			this.LbBinoN.Text = "Valeur de n";
			// 
			// TxtKValBino
			// 
			this.TxtKValBino.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtKValBino.Location = new System.Drawing.Point(255, 391);
			this.TxtKValBino.Margin = new System.Windows.Forms.Padding(4);
			this.TxtKValBino.Name = "TxtKValBino";
			this.TxtKValBino.Size = new System.Drawing.Size(180, 49);
			this.TxtKValBino.TabIndex = 19;
			// 
			// TxtNValBino
			// 
			this.TxtNValBino.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtNValBino.Location = new System.Drawing.Point(255, 334);
			this.TxtNValBino.Margin = new System.Windows.Forms.Padding(4);
			this.TxtNValBino.Name = "TxtNValBino";
			this.TxtNValBino.Size = new System.Drawing.Size(180, 49);
			this.TxtNValBino.TabIndex = 15;
			// 
			// LbBinoK
			// 
			this.LbBinoK.AutoSize = true;
			this.LbBinoK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LbBinoK.Location = new System.Drawing.Point(14, 398);
			this.LbBinoK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LbBinoK.Name = "LbBinoK";
			this.LbBinoK.Size = new System.Drawing.Size(207, 42);
			this.LbBinoK.TabIndex = 18;
			this.LbBinoK.Text = "Valeur de k";
			// 
			// BtnBinoCalc
			// 
			this.BtnBinoCalc.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BtnBinoCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnBinoCalc.Location = new System.Drawing.Point(459, 396);
			this.BtnBinoCalc.Margin = new System.Windows.Forms.Padding(4);
			this.BtnBinoCalc.Name = "BtnBinoCalc";
			this.BtnBinoCalc.Size = new System.Drawing.Size(201, 101);
			this.BtnBinoCalc.TabIndex = 16;
			this.BtnBinoCalc.Text = "Calculer";
			this.BtnBinoCalc.UseVisualStyleBackColor = true;
			this.BtnBinoCalc.Click += new System.EventHandler(this.BtnBinoCalc_Click);
			// 
			// ImgBino
			// 
			this.ImgBino.Image = global::CalculAlgo.Properties.Resources.Bino;
			this.ImgBino.Location = new System.Drawing.Point(19, 56);
			this.ImgBino.Margin = new System.Windows.Forms.Padding(4);
			this.ImgBino.Name = "ImgBino";
			this.ImgBino.Size = new System.Drawing.Size(848, 255);
			this.ImgBino.TabIndex = 20;
			this.ImgBino.TabStop = false;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.RdBtnPoissEgal);
			this.tabPage4.Controls.Add(this.RdBtnPoissInfEgal);
			this.tabPage4.Controls.Add(this.RdBtnPoissInf);
			this.tabPage4.Controls.Add(this.BtnPoissonClear);
			this.tabPage4.Controls.Add(this.TxtResultPoiss);
			this.tabPage4.Controls.Add(this.LbPoisLamb);
			this.tabPage4.Controls.Add(this.TxtPoissonKVal);
			this.tabPage4.Controls.Add(this.TxtPoissonLambdaVal);
			this.tabPage4.Controls.Add(this.LbPoissK);
			this.tabPage4.Controls.Add(this.BtnPoissonCalc);
			this.tabPage4.Controls.Add(this.ImgPoiss);
			this.tabPage4.Location = new System.Drawing.Point(8, 39);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(886, 963);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Loi de Poisson";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// RdBtnPoissEgal
			// 
			this.RdBtnPoissEgal.AutoSize = true;
			this.RdBtnPoissEgal.Checked = true;
			this.RdBtnPoissEgal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RdBtnPoissEgal.Location = new System.Drawing.Point(8, 492);
			this.RdBtnPoissEgal.Name = "RdBtnPoissEgal";
			this.RdBtnPoissEgal.Size = new System.Drawing.Size(137, 48);
			this.RdBtnPoissEgal.TabIndex = 45;
			this.RdBtnPoissEgal.TabStop = true;
			this.RdBtnPoissEgal.Text = "X = k";
			this.RdBtnPoissEgal.UseVisualStyleBackColor = true;
			// 
			// RdBtnPoissInfEgal
			// 
			this.RdBtnPoissInfEgal.AutoSize = true;
			this.RdBtnPoissInfEgal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RdBtnPoissInfEgal.Location = new System.Drawing.Point(732, 492);
			this.RdBtnPoissInfEgal.Name = "RdBtnPoissInfEgal";
			this.RdBtnPoissInfEgal.Size = new System.Drawing.Size(137, 48);
			this.RdBtnPoissInfEgal.TabIndex = 43;
			this.RdBtnPoissInfEgal.TabStop = true;
			this.RdBtnPoissInfEgal.Text = "X ≤ k";
			this.RdBtnPoissInfEgal.UseVisualStyleBackColor = true;
			// 
			// RdBtnPoissInf
			// 
			this.RdBtnPoissInf.AutoSize = true;
			this.RdBtnPoissInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RdBtnPoissInf.Location = new System.Drawing.Point(370, 492);
			this.RdBtnPoissInf.Name = "RdBtnPoissInf";
			this.RdBtnPoissInf.Size = new System.Drawing.Size(137, 48);
			this.RdBtnPoissInf.TabIndex = 41;
			this.RdBtnPoissInf.TabStop = true;
			this.RdBtnPoissInf.Text = "X < k";
			this.RdBtnPoissInf.UseVisualStyleBackColor = true;
			// 
			// BtnPoissonClear
			// 
			this.BtnPoissonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnPoissonClear.Location = new System.Drawing.Point(651, 364);
			this.BtnPoissonClear.Name = "BtnPoissonClear";
			this.BtnPoissonClear.Size = new System.Drawing.Size(218, 101);
			this.BtnPoissonClear.TabIndex = 40;
			this.BtnPoissonClear.Text = "Clear";
			this.BtnPoissonClear.UseVisualStyleBackColor = true;
			this.BtnPoissonClear.Click += new System.EventHandler(this.BtnPoissonClear_Click);
			// 
			// TxtResultPoiss
			// 
			this.TxtResultPoiss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtResultPoiss.Location = new System.Drawing.Point(7, 547);
			this.TxtResultPoiss.Margin = new System.Windows.Forms.Padding(4);
			this.TxtResultPoiss.Name = "TxtResultPoiss";
			this.TxtResultPoiss.ReadOnly = true;
			this.TxtResultPoiss.Size = new System.Drawing.Size(863, 401);
			this.TxtResultPoiss.TabIndex = 39;
			this.TxtResultPoiss.Text = "";
			// 
			// LbPoisLamb
			// 
			this.LbPoisLamb.AutoSize = true;
			this.LbPoisLamb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LbPoisLamb.Location = new System.Drawing.Point(7, 372);
			this.LbPoisLamb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LbPoisLamb.Name = "LbPoisLamb";
			this.LbPoisLamb.Size = new System.Drawing.Size(207, 42);
			this.LbPoisLamb.TabIndex = 32;
			this.LbPoisLamb.Text = "Valeur de λ";
			// 
			// TxtPoissonKVal
			// 
			this.TxtPoissonKVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtPoissonKVal.Location = new System.Drawing.Point(222, 422);
			this.TxtPoissonKVal.Margin = new System.Windows.Forms.Padding(4);
			this.TxtPoissonKVal.Name = "TxtPoissonKVal";
			this.TxtPoissonKVal.Size = new System.Drawing.Size(180, 49);
			this.TxtPoissonKVal.TabIndex = 36;
			// 
			// TxtPoissonLambdaVal
			// 
			this.TxtPoissonLambdaVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtPoissonLambdaVal.Location = new System.Drawing.Point(222, 365);
			this.TxtPoissonLambdaVal.Margin = new System.Windows.Forms.Padding(4);
			this.TxtPoissonLambdaVal.Name = "TxtPoissonLambdaVal";
			this.TxtPoissonLambdaVal.Size = new System.Drawing.Size(180, 49);
			this.TxtPoissonLambdaVal.TabIndex = 33;
			// 
			// LbPoissK
			// 
			this.LbPoissK.AutoSize = true;
			this.LbPoissK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LbPoissK.Location = new System.Drawing.Point(7, 429);
			this.LbPoissK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LbPoissK.Name = "LbPoissK";
			this.LbPoissK.Size = new System.Drawing.Size(207, 42);
			this.LbPoissK.TabIndex = 35;
			this.LbPoissK.Text = "Valeur de k";
			// 
			// BtnPoissonCalc
			// 
			this.BtnPoissonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnPoissonCalc.Location = new System.Drawing.Point(426, 364);
			this.BtnPoissonCalc.Margin = new System.Windows.Forms.Padding(4);
			this.BtnPoissonCalc.Name = "BtnPoissonCalc";
			this.BtnPoissonCalc.Size = new System.Drawing.Size(218, 101);
			this.BtnPoissonCalc.TabIndex = 34;
			this.BtnPoissonCalc.Text = "Calculer";
			this.BtnPoissonCalc.UseVisualStyleBackColor = true;
			this.BtnPoissonCalc.Click += new System.EventHandler(this.BtnPoissonCalc_Click);
			// 
			// ImgPoiss
			// 
			this.ImgPoiss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ImgPoiss.Image = global::CalculAlgo.Properties.Resources.Poisson;
			this.ImgPoiss.ImageLocation = "";
			this.ImgPoiss.Location = new System.Drawing.Point(7, 49);
			this.ImgPoiss.Margin = new System.Windows.Forms.Padding(4);
			this.ImgPoiss.Name = "ImgPoiss";
			this.ImgPoiss.Size = new System.Drawing.Size(863, 308);
			this.ImgPoiss.TabIndex = 14;
			this.ImgPoiss.TabStop = false;
			// 
			// FrmCalculAlgo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(918, 1026);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmCalculAlgo";
			this.Text = "CalculAlgo";
			this.tabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.TabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ImgComb)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ImgArr)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ImgBino)).EndInit();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ImgPoiss)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox ImgArr;
        private System.Windows.Forms.Label LbArrN;
        private System.Windows.Forms.TextBox TxtKValArr;
        private System.Windows.Forms.TextBox TxtNValArr;
        private System.Windows.Forms.Label LbArrK;
        private System.Windows.Forms.Button BtnArrCalc;
        private System.Windows.Forms.TextBox TxtResultArr;
        private System.Windows.Forms.PictureBox ImgBino;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.PictureBox ImgComb;
		private System.Windows.Forms.Label LbCombN;
		private System.Windows.Forms.TextBox TxtKValComb;
		private System.Windows.Forms.TextBox TxtNValComb;
		private System.Windows.Forms.Label LbCombK;
		private System.Windows.Forms.Button BtnCombCalc;
		private System.Windows.Forms.TextBox TxtResultComb;
		private System.Windows.Forms.RadioButton RdBtnBinoEgal;
		private System.Windows.Forms.RadioButton RdBtnBinoSupEgal;
		private System.Windows.Forms.RadioButton RdBtnBinoInfEgal;
		private System.Windows.Forms.RadioButton RdBtnBinoSup;
		private System.Windows.Forms.RadioButton RdBtnBinoInf;
		private System.Windows.Forms.Button BtnBinoClear;
		private System.Windows.Forms.RichTextBox TxtResultBino;
		private System.Windows.Forms.TextBox TxtPValBino;
		private System.Windows.Forms.Label LbBinoP;
		private System.Windows.Forms.Label LbBinoN;
		private System.Windows.Forms.TextBox TxtKValBino;
		private System.Windows.Forms.TextBox TxtNValBino;
		private System.Windows.Forms.Label LbBinoK;
		private System.Windows.Forms.Button BtnBinoCalc;
		private System.Windows.Forms.RadioButton RdBtnPoissEgal;
		private System.Windows.Forms.RadioButton RdBtnPoissInfEgal;
		private System.Windows.Forms.RadioButton RdBtnPoissInf;
		private System.Windows.Forms.Button BtnPoissonClear;
		private System.Windows.Forms.RichTextBox TxtResultPoiss;
		private System.Windows.Forms.Label LbPoisLamb;
		private System.Windows.Forms.TextBox TxtPoissonKVal;
		private System.Windows.Forms.TextBox TxtPoissonLambdaVal;
		private System.Windows.Forms.Label LbPoissK;
		private System.Windows.Forms.Button BtnPoissonCalc;
		private System.Windows.Forms.PictureBox ImgPoiss;
	}
}

