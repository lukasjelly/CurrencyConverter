
namespace Assignment1
{
    partial class currencyConversionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(currencyConversionForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelDateTime = new System.Windows.Forms.Label();
            this.dateTimeNamePhotoResult = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.checkBoxPhoto = new System.Windows.Forms.CheckBox();
            this.usersPhoto = new System.Windows.Forms.PictureBox();
            this.labelConvertHowMuch = new System.Windows.Forms.Label();
            this.labelConversionInfo = new System.Windows.Forms.Label();
            this.labelFromCurrency = new System.Windows.Forms.Label();
            this.labelToCurrency = new System.Windows.Forms.Label();
            this.numericUpDownAmountToConvert = new System.Windows.Forms.NumericUpDown();
            this.groupBoxFromCurrency = new System.Windows.Forms.GroupBox();
            this.radioButtonFromUSD = new System.Windows.Forms.RadioButton();
            this.radioButtonFromCAD = new System.Windows.Forms.RadioButton();
            this.radioButtonFromINR = new System.Windows.Forms.RadioButton();
            this.radioButtonFromAUD = new System.Windows.Forms.RadioButton();
            this.radioButtonFromEUR = new System.Windows.Forms.RadioButton();
            this.radioButtonFromRMB = new System.Windows.Forms.RadioButton();
            this.radioButtonFromNZD = new System.Windows.Forms.RadioButton();
            this.radioButtonFromAED = new System.Windows.Forms.RadioButton();
            this.radioButtonFromYEN = new System.Windows.Forms.RadioButton();
            this.groupBoxToCurrency = new System.Windows.Forms.GroupBox();
            this.radioButtonToUSD = new System.Windows.Forms.RadioButton();
            this.radioButtonToCAD = new System.Windows.Forms.RadioButton();
            this.radioButtonToINR = new System.Windows.Forms.RadioButton();
            this.radioButtonToAUD = new System.Windows.Forms.RadioButton();
            this.radioButtonToEUR = new System.Windows.Forms.RadioButton();
            this.radioButtonToRMB = new System.Windows.Forms.RadioButton();
            this.radioButtonToNZD = new System.Windows.Forms.RadioButton();
            this.radioButtonToAED = new System.Windows.Forms.RadioButton();
            this.radioButtonToYEN = new System.Windows.Forms.RadioButton();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.dateTimeNamePhotoResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountToConvert)).BeginInit();
            this.groupBoxFromCurrency.SuspendLayout();
            this.groupBoxToCurrency.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelDateTime
            // 
            this.labelDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateTime.Location = new System.Drawing.Point(376, 16);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(271, 56);
            this.labelDateTime.TabIndex = 0;
            // 
            // dateTimeNamePhotoResult
            // 
            this.dateTimeNamePhotoResult.Controls.Add(this.labelResult);
            this.dateTimeNamePhotoResult.Controls.Add(this.textBoxUserName);
            this.dateTimeNamePhotoResult.Controls.Add(this.labelUserName);
            this.dateTimeNamePhotoResult.Controls.Add(this.checkBoxPhoto);
            this.dateTimeNamePhotoResult.Controls.Add(this.usersPhoto);
            this.dateTimeNamePhotoResult.Controls.Add(this.labelDateTime);
            this.dateTimeNamePhotoResult.Location = new System.Drawing.Point(3, 2);
            this.dateTimeNamePhotoResult.Name = "dateTimeNamePhotoResult";
            this.dateTimeNamePhotoResult.Size = new System.Drawing.Size(1042, 244);
            this.dateTimeNamePhotoResult.TabIndex = 1;
            this.dateTimeNamePhotoResult.TabStop = false;
            // 
            // labelResult
            // 
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(8, 134);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(880, 98);
            this.labelResult.TabIndex = 5;
            this.labelResult.Text = "Result: ";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(107, 61);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(204, 31);
            this.textBoxUserName.TabIndex = 4;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(9, 63);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(92, 18);
            this.labelUserName.TabIndex = 3;
            this.labelUserName.Text = "My name is: ";
            // 
            // checkBoxPhoto
            // 
            this.checkBoxPhoto.AutoSize = true;
            this.checkBoxPhoto.Location = new System.Drawing.Point(894, 20);
            this.checkBoxPhoto.Name = "checkBoxPhoto";
            this.checkBoxPhoto.Size = new System.Drawing.Size(93, 17);
            this.checkBoxPhoto.TabIndex = 2;
            this.checkBoxPhoto.Text = "See My Photo";
            this.checkBoxPhoto.UseVisualStyleBackColor = true;
            this.checkBoxPhoto.CheckedChanged += new System.EventHandler(this.checkBoxPhoto_CheckedChanged);
            // 
            // usersPhoto
            // 
            this.usersPhoto.Image = ((System.Drawing.Image)(resources.GetObject("usersPhoto.Image")));
            this.usersPhoto.Location = new System.Drawing.Point(894, 63);
            this.usersPhoto.Name = "usersPhoto";
            this.usersPhoto.Size = new System.Drawing.Size(123, 131);
            this.usersPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.usersPhoto.TabIndex = 1;
            this.usersPhoto.TabStop = false;
            this.usersPhoto.Visible = false;
            // 
            // labelConvertHowMuch
            // 
            this.labelConvertHowMuch.AutoSize = true;
            this.labelConvertHowMuch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConvertHowMuch.Location = new System.Drawing.Point(210, 284);
            this.labelConvertHowMuch.Name = "labelConvertHowMuch";
            this.labelConvertHowMuch.Size = new System.Drawing.Size(123, 16);
            this.labelConvertHowMuch.TabIndex = 2;
            this.labelConvertHowMuch.Text = "I want to convert:";
            // 
            // labelConversionInfo
            // 
            this.labelConversionInfo.AutoSize = true;
            this.labelConversionInfo.Location = new System.Drawing.Point(488, 284);
            this.labelConversionInfo.Name = "labelConversionInfo";
            this.labelConversionInfo.Size = new System.Drawing.Size(192, 13);
            this.labelConversionInfo.TabIndex = 4;
            this.labelConversionInfo.Text = "(Amount of money you want to convert)";
            // 
            // labelFromCurrency
            // 
            this.labelFromCurrency.AutoSize = true;
            this.labelFromCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFromCurrency.Location = new System.Drawing.Point(123, 411);
            this.labelFromCurrency.Name = "labelFromCurrency";
            this.labelFromCurrency.Size = new System.Drawing.Size(72, 25);
            this.labelFromCurrency.TabIndex = 7;
            this.labelFromCurrency.Text = "From:";
            // 
            // labelToCurrency
            // 
            this.labelToCurrency.AutoSize = true;
            this.labelToCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToCurrency.Location = new System.Drawing.Point(604, 412);
            this.labelToCurrency.Name = "labelToCurrency";
            this.labelToCurrency.Size = new System.Drawing.Size(46, 25);
            this.labelToCurrency.TabIndex = 8;
            this.labelToCurrency.Text = "To:";
            // 
            // numericUpDownAmountToConvert
            // 
            this.numericUpDownAmountToConvert.DecimalPlaces = 2;
            this.numericUpDownAmountToConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownAmountToConvert.Location = new System.Drawing.Point(353, 284);
            this.numericUpDownAmountToConvert.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownAmountToConvert.Name = "numericUpDownAmountToConvert";
            this.numericUpDownAmountToConvert.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownAmountToConvert.TabIndex = 9;
            // 
            // groupBoxFromCurrency
            // 
            this.groupBoxFromCurrency.Controls.Add(this.radioButtonFromUSD);
            this.groupBoxFromCurrency.Controls.Add(this.radioButtonFromCAD);
            this.groupBoxFromCurrency.Controls.Add(this.radioButtonFromINR);
            this.groupBoxFromCurrency.Controls.Add(this.radioButtonFromAUD);
            this.groupBoxFromCurrency.Controls.Add(this.radioButtonFromEUR);
            this.groupBoxFromCurrency.Controls.Add(this.radioButtonFromRMB);
            this.groupBoxFromCurrency.Controls.Add(this.radioButtonFromNZD);
            this.groupBoxFromCurrency.Controls.Add(this.radioButtonFromAED);
            this.groupBoxFromCurrency.Controls.Add(this.radioButtonFromYEN);
            this.groupBoxFromCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFromCurrency.Location = new System.Drawing.Point(201, 358);
            this.groupBoxFromCurrency.Name = "groupBoxFromCurrency";
            this.groupBoxFromCurrency.Size = new System.Drawing.Size(318, 127);
            this.groupBoxFromCurrency.TabIndex = 11;
            this.groupBoxFromCurrency.TabStop = false;
            this.groupBoxFromCurrency.Text = "Please select money you want to convert:";
            // 
            // radioButtonFromUSD
            // 
            this.radioButtonFromUSD.AutoSize = true;
            this.radioButtonFromUSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFromUSD.Location = new System.Drawing.Point(6, 25);
            this.radioButtonFromUSD.Name = "radioButtonFromUSD";
            this.radioButtonFromUSD.Size = new System.Drawing.Size(65, 24);
            this.radioButtonFromUSD.TabIndex = 9;
            this.radioButtonFromUSD.TabStop = true;
            this.radioButtonFromUSD.Text = "USD";
            this.radioButtonFromUSD.UseVisualStyleBackColor = true;
            // 
            // radioButtonFromCAD
            // 
            this.radioButtonFromCAD.AutoSize = true;
            this.radioButtonFromCAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFromCAD.Location = new System.Drawing.Point(77, 26);
            this.radioButtonFromCAD.Name = "radioButtonFromCAD";
            this.radioButtonFromCAD.Size = new System.Drawing.Size(64, 24);
            this.radioButtonFromCAD.TabIndex = 10;
            this.radioButtonFromCAD.TabStop = true;
            this.radioButtonFromCAD.Text = "CAD";
            this.radioButtonFromCAD.UseVisualStyleBackColor = true;
            // 
            // radioButtonFromINR
            // 
            this.radioButtonFromINR.AutoSize = true;
            this.radioButtonFromINR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFromINR.Location = new System.Drawing.Point(149, 24);
            this.radioButtonFromINR.Name = "radioButtonFromINR";
            this.radioButtonFromINR.Size = new System.Drawing.Size(58, 24);
            this.radioButtonFromINR.TabIndex = 11;
            this.radioButtonFromINR.TabStop = true;
            this.radioButtonFromINR.Text = "INR";
            this.radioButtonFromINR.UseVisualStyleBackColor = true;
            // 
            // radioButtonFromAUD
            // 
            this.radioButtonFromAUD.AutoSize = true;
            this.radioButtonFromAUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFromAUD.Location = new System.Drawing.Point(6, 56);
            this.radioButtonFromAUD.Name = "radioButtonFromAUD";
            this.radioButtonFromAUD.Size = new System.Drawing.Size(65, 24);
            this.radioButtonFromAUD.TabIndex = 12;
            this.radioButtonFromAUD.TabStop = true;
            this.radioButtonFromAUD.Text = "AUD";
            this.radioButtonFromAUD.UseVisualStyleBackColor = true;
            // 
            // radioButtonFromEUR
            // 
            this.radioButtonFromEUR.AutoSize = true;
            this.radioButtonFromEUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFromEUR.Location = new System.Drawing.Point(77, 55);
            this.radioButtonFromEUR.Name = "radioButtonFromEUR";
            this.radioButtonFromEUR.Size = new System.Drawing.Size(65, 24);
            this.radioButtonFromEUR.TabIndex = 13;
            this.radioButtonFromEUR.TabStop = true;
            this.radioButtonFromEUR.Text = "EUR";
            this.radioButtonFromEUR.UseVisualStyleBackColor = true;
            // 
            // radioButtonFromRMB
            // 
            this.radioButtonFromRMB.AutoSize = true;
            this.radioButtonFromRMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFromRMB.Location = new System.Drawing.Point(149, 56);
            this.radioButtonFromRMB.Name = "radioButtonFromRMB";
            this.radioButtonFromRMB.Size = new System.Drawing.Size(66, 24);
            this.radioButtonFromRMB.TabIndex = 14;
            this.radioButtonFromRMB.TabStop = true;
            this.radioButtonFromRMB.Text = "RMB";
            this.radioButtonFromRMB.UseVisualStyleBackColor = true;
            // 
            // radioButtonFromNZD
            // 
            this.radioButtonFromNZD.AutoSize = true;
            this.radioButtonFromNZD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFromNZD.Location = new System.Drawing.Point(5, 86);
            this.radioButtonFromNZD.Name = "radioButtonFromNZD";
            this.radioButtonFromNZD.Size = new System.Drawing.Size(63, 24);
            this.radioButtonFromNZD.TabIndex = 15;
            this.radioButtonFromNZD.TabStop = true;
            this.radioButtonFromNZD.Text = "NZD";
            this.radioButtonFromNZD.UseVisualStyleBackColor = true;
            // 
            // radioButtonFromAED
            // 
            this.radioButtonFromAED.AutoSize = true;
            this.radioButtonFromAED.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFromAED.Location = new System.Drawing.Point(77, 86);
            this.radioButtonFromAED.Name = "radioButtonFromAED";
            this.radioButtonFromAED.Size = new System.Drawing.Size(64, 24);
            this.radioButtonFromAED.TabIndex = 16;
            this.radioButtonFromAED.TabStop = true;
            this.radioButtonFromAED.Text = "AED";
            this.radioButtonFromAED.UseVisualStyleBackColor = true;
            // 
            // radioButtonFromYEN
            // 
            this.radioButtonFromYEN.AutoSize = true;
            this.radioButtonFromYEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFromYEN.Location = new System.Drawing.Point(149, 85);
            this.radioButtonFromYEN.Name = "radioButtonFromYEN";
            this.radioButtonFromYEN.Size = new System.Drawing.Size(63, 24);
            this.radioButtonFromYEN.TabIndex = 17;
            this.radioButtonFromYEN.TabStop = true;
            this.radioButtonFromYEN.Text = "YEN";
            this.radioButtonFromYEN.UseVisualStyleBackColor = true;
            // 
            // groupBoxToCurrency
            // 
            this.groupBoxToCurrency.Controls.Add(this.radioButtonToUSD);
            this.groupBoxToCurrency.Controls.Add(this.radioButtonToCAD);
            this.groupBoxToCurrency.Controls.Add(this.radioButtonToINR);
            this.groupBoxToCurrency.Controls.Add(this.radioButtonToAUD);
            this.groupBoxToCurrency.Controls.Add(this.radioButtonToEUR);
            this.groupBoxToCurrency.Controls.Add(this.radioButtonToRMB);
            this.groupBoxToCurrency.Controls.Add(this.radioButtonToNZD);
            this.groupBoxToCurrency.Controls.Add(this.radioButtonToAED);
            this.groupBoxToCurrency.Controls.Add(this.radioButtonToYEN);
            this.groupBoxToCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBoxToCurrency.Location = new System.Drawing.Point(656, 358);
            this.groupBoxToCurrency.Name = "groupBoxToCurrency";
            this.groupBoxToCurrency.Size = new System.Drawing.Size(334, 127);
            this.groupBoxToCurrency.TabIndex = 12;
            this.groupBoxToCurrency.TabStop = false;
            this.groupBoxToCurrency.Text = "Please select money you want to convert to:";
            // 
            // radioButtonToUSD
            // 
            this.radioButtonToUSD.AutoSize = true;
            this.radioButtonToUSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonToUSD.Location = new System.Drawing.Point(6, 25);
            this.radioButtonToUSD.Name = "radioButtonToUSD";
            this.radioButtonToUSD.Size = new System.Drawing.Size(65, 24);
            this.radioButtonToUSD.TabIndex = 18;
            this.radioButtonToUSD.TabStop = true;
            this.radioButtonToUSD.Text = "USD";
            this.radioButtonToUSD.UseVisualStyleBackColor = true;
            // 
            // radioButtonToCAD
            // 
            this.radioButtonToCAD.AutoSize = true;
            this.radioButtonToCAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.radioButtonToCAD.Location = new System.Drawing.Point(77, 26);
            this.radioButtonToCAD.Name = "radioButtonToCAD";
            this.radioButtonToCAD.Size = new System.Drawing.Size(64, 24);
            this.radioButtonToCAD.TabIndex = 19;
            this.radioButtonToCAD.TabStop = true;
            this.radioButtonToCAD.Text = "CAD";
            this.radioButtonToCAD.UseVisualStyleBackColor = true;
            // 
            // radioButtonToINR
            // 
            this.radioButtonToINR.AutoSize = true;
            this.radioButtonToINR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.radioButtonToINR.Location = new System.Drawing.Point(154, 26);
            this.radioButtonToINR.Name = "radioButtonToINR";
            this.radioButtonToINR.Size = new System.Drawing.Size(58, 24);
            this.radioButtonToINR.TabIndex = 20;
            this.radioButtonToINR.TabStop = true;
            this.radioButtonToINR.Text = "INR";
            this.radioButtonToINR.UseVisualStyleBackColor = true;
            // 
            // radioButtonToAUD
            // 
            this.radioButtonToAUD.AutoSize = true;
            this.radioButtonToAUD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonToAUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.radioButtonToAUD.Location = new System.Drawing.Point(6, 54);
            this.radioButtonToAUD.Name = "radioButtonToAUD";
            this.radioButtonToAUD.Size = new System.Drawing.Size(71, 25);
            this.radioButtonToAUD.TabIndex = 21;
            this.radioButtonToAUD.TabStop = true;
            this.radioButtonToAUD.Text = "AUD";
            this.radioButtonToAUD.UseVisualStyleBackColor = true;
            // 
            // radioButtonToEUR
            // 
            this.radioButtonToEUR.AutoSize = true;
            this.radioButtonToEUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.radioButtonToEUR.Location = new System.Drawing.Point(77, 56);
            this.radioButtonToEUR.Name = "radioButtonToEUR";
            this.radioButtonToEUR.Size = new System.Drawing.Size(65, 24);
            this.radioButtonToEUR.TabIndex = 22;
            this.radioButtonToEUR.TabStop = true;
            this.radioButtonToEUR.Text = "EUR";
            this.radioButtonToEUR.UseVisualStyleBackColor = true;
            // 
            // radioButtonToRMB
            // 
            this.radioButtonToRMB.AutoSize = true;
            this.radioButtonToRMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.radioButtonToRMB.Location = new System.Drawing.Point(154, 53);
            this.radioButtonToRMB.Name = "radioButtonToRMB";
            this.radioButtonToRMB.Size = new System.Drawing.Size(66, 24);
            this.radioButtonToRMB.TabIndex = 23;
            this.radioButtonToRMB.TabStop = true;
            this.radioButtonToRMB.Text = "RMB";
            this.radioButtonToRMB.UseVisualStyleBackColor = true;
            // 
            // radioButtonToNZD
            // 
            this.radioButtonToNZD.AutoSize = true;
            this.radioButtonToNZD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.radioButtonToNZD.Location = new System.Drawing.Point(6, 86);
            this.radioButtonToNZD.Name = "radioButtonToNZD";
            this.radioButtonToNZD.Size = new System.Drawing.Size(63, 24);
            this.radioButtonToNZD.TabIndex = 24;
            this.radioButtonToNZD.TabStop = true;
            this.radioButtonToNZD.Text = "NZD";
            this.radioButtonToNZD.UseVisualStyleBackColor = true;
            // 
            // radioButtonToAED
            // 
            this.radioButtonToAED.AutoSize = true;
            this.radioButtonToAED.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.radioButtonToAED.Location = new System.Drawing.Point(77, 85);
            this.radioButtonToAED.Name = "radioButtonToAED";
            this.radioButtonToAED.Size = new System.Drawing.Size(64, 24);
            this.radioButtonToAED.TabIndex = 25;
            this.radioButtonToAED.TabStop = true;
            this.radioButtonToAED.Text = "AED";
            this.radioButtonToAED.UseVisualStyleBackColor = true;
            // 
            // radioButtonToYEN
            // 
            this.radioButtonToYEN.AutoSize = true;
            this.radioButtonToYEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.radioButtonToYEN.Location = new System.Drawing.Point(154, 85);
            this.radioButtonToYEN.Name = "radioButtonToYEN";
            this.radioButtonToYEN.Size = new System.Drawing.Size(63, 24);
            this.radioButtonToYEN.TabIndex = 26;
            this.radioButtonToYEN.TabStop = true;
            this.radioButtonToYEN.Text = "YEN";
            this.radioButtonToYEN.UseVisualStyleBackColor = true;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.buttonConfirm.Location = new System.Drawing.Point(399, 519);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(212, 51);
            this.buttonConfirm.TabIndex = 13;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // currencyConversionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 582);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.groupBoxToCurrency);
            this.Controls.Add(this.groupBoxFromCurrency);
            this.Controls.Add(this.numericUpDownAmountToConvert);
            this.Controls.Add(this.labelToCurrency);
            this.Controls.Add(this.labelFromCurrency);
            this.Controls.Add(this.labelConversionInfo);
            this.Controls.Add(this.labelConvertHowMuch);
            this.Controls.Add(this.dateTimeNamePhotoResult);
            this.Name = "currencyConversionForm";
            this.Text = "20009320(ID) Conversion Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.dateTimeNamePhotoResult.ResumeLayout(false);
            this.dateTimeNamePhotoResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountToConvert)).EndInit();
            this.groupBoxFromCurrency.ResumeLayout(false);
            this.groupBoxFromCurrency.PerformLayout();
            this.groupBoxToCurrency.ResumeLayout(false);
            this.groupBoxToCurrency.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.GroupBox dateTimeNamePhotoResult;
        private System.Windows.Forms.PictureBox usersPhoto;
        private System.Windows.Forms.CheckBox checkBoxPhoto;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelConvertHowMuch;
        private System.Windows.Forms.Label labelConversionInfo;
        private System.Windows.Forms.Label labelFromCurrency;
        private System.Windows.Forms.Label labelToCurrency;
        private System.Windows.Forms.NumericUpDown numericUpDownAmountToConvert;
        private System.Windows.Forms.GroupBox groupBoxFromCurrency;
        private System.Windows.Forms.RadioButton radioButtonFromUSD;
        private System.Windows.Forms.RadioButton radioButtonFromCAD;
        private System.Windows.Forms.RadioButton radioButtonFromINR;
        private System.Windows.Forms.RadioButton radioButtonFromAUD;
        private System.Windows.Forms.RadioButton radioButtonFromEUR;
        private System.Windows.Forms.RadioButton radioButtonFromRMB;
        private System.Windows.Forms.RadioButton radioButtonFromNZD;
        private System.Windows.Forms.RadioButton radioButtonFromAED;
        private System.Windows.Forms.RadioButton radioButtonFromYEN;
        private System.Windows.Forms.GroupBox groupBoxToCurrency;
        private System.Windows.Forms.RadioButton radioButtonToUSD;
        private System.Windows.Forms.RadioButton radioButtonToCAD;
        private System.Windows.Forms.RadioButton radioButtonToINR;
        private System.Windows.Forms.RadioButton radioButtonToAUD;
        private System.Windows.Forms.RadioButton radioButtonToEUR;
        private System.Windows.Forms.RadioButton radioButtonToRMB;
        private System.Windows.Forms.RadioButton radioButtonToNZD;
        private System.Windows.Forms.RadioButton radioButtonToAED;
        private System.Windows.Forms.RadioButton radioButtonToYEN;
        private System.Windows.Forms.Button buttonConfirm;
    }
}

