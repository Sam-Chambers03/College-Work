namespace QuoteCalculatorAssignment
{
    partial class Form1
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
            this.lName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lDate = new System.Windows.Forms.Label();
            this.cbMouldingTechnique = new System.Windows.Forms.ComboBox();
            this.lMouldingTech = new System.Windows.Forms.Label();
            this.lMaterial = new System.Windows.Forms.Label();
            this.cbMaterialType = new System.Windows.Forms.ComboBox();
            this.lProductColour = new System.Windows.Forms.Label();
            this.rbStandardRange = new System.Windows.Forms.RadioButton();
            this.rbBespokeRange = new System.Windows.Forms.RadioButton();
            this.lComponentsNeeded = new System.Windows.Forms.Label();
            this.tbNumComponents = new System.Windows.Forms.TextBox();
            this.lQuantity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumTransfers = new System.Windows.Forms.TextBox();
            this.lDesignMould = new System.Windows.Forms.Label();
            this.cbMoulds = new System.Windows.Forms.ComboBox();
            this.bCalculate = new System.Windows.Forms.Button();
            this.bSaveQuote = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.cbFettling = new System.Windows.Forms.CheckBox();
            this.cbHandPainting = new System.Windows.Forms.CheckBox();
            this.cbTransfersUsed = new System.Windows.Forms.CheckBox();
            this.tbNumColoursUsed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.labelFinalPrice = new System.Windows.Forms.Label();
            this.tbfinalPrice = new System.Windows.Forms.TextBox();
            this.cbPartsAssembly = new System.Windows.Forms.CheckBox();
            this.tbNumParts = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbDate = new System.Windows.Forms.DateTimePicker();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(27, 29);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(38, 13);
            this.lName.TabIndex = 0;
            this.lName.Text = "Name ";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(71, 26);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(170, 20);
            this.tbName.TabIndex = 1;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbName_KeyPress);
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Location = new System.Drawing.Point(259, 29);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(30, 13);
            this.lDate.TabIndex = 2;
            this.lDate.Text = "Date";
            // 
            // cbMouldingTechnique
            // 
            this.cbMouldingTechnique.AllowDrop = true;
            this.cbMouldingTechnique.FormattingEnabled = true;
            this.cbMouldingTechnique.Items.AddRange(new object[] {
            "Vacuum Moulding",
            "Blow Moulding",
            "Injection Moulding",
            "Coating"});
            this.cbMouldingTechnique.Location = new System.Drawing.Point(43, 143);
            this.cbMouldingTechnique.Name = "cbMouldingTechnique";
            this.cbMouldingTechnique.Size = new System.Drawing.Size(147, 21);
            this.cbMouldingTechnique.TabIndex = 4;
            this.cbMouldingTechnique.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // lMouldingTech
            // 
            this.lMouldingTech.AutoSize = true;
            this.lMouldingTech.Location = new System.Drawing.Point(43, 124);
            this.lMouldingTech.Name = "lMouldingTech";
            this.lMouldingTech.Size = new System.Drawing.Size(104, 13);
            this.lMouldingTech.TabIndex = 5;
            this.lMouldingTech.Text = "Moulding Technique";
            // 
            // lMaterial
            // 
            this.lMaterial.AutoSize = true;
            this.lMaterial.Location = new System.Drawing.Point(43, 196);
            this.lMaterial.Name = "lMaterial";
            this.lMaterial.Size = new System.Drawing.Size(71, 13);
            this.lMaterial.TabIndex = 7;
            this.lMaterial.Text = "Material Type";
            // 
            // cbMaterialType
            // 
            this.cbMaterialType.AllowDrop = true;
            this.cbMaterialType.FormattingEnabled = true;
            this.cbMaterialType.Items.AddRange(new object[] {
            "HDPE",
            "LDPE",
            "PVC",
            "uPVC",
            "Acrylic",
            "HDPS"});
            this.cbMaterialType.Location = new System.Drawing.Point(43, 215);
            this.cbMaterialType.Name = "cbMaterialType";
            this.cbMaterialType.Size = new System.Drawing.Size(147, 21);
            this.cbMaterialType.TabIndex = 6;
            // 
            // lProductColour
            // 
            this.lProductColour.AutoSize = true;
            this.lProductColour.Location = new System.Drawing.Point(43, 261);
            this.lProductColour.Name = "lProductColour";
            this.lProductColour.Size = new System.Drawing.Size(77, 13);
            this.lProductColour.TabIndex = 8;
            this.lProductColour.Text = "Product Colour";
            // 
            // rbStandardRange
            // 
            this.rbStandardRange.AutoSize = true;
            this.rbStandardRange.Location = new System.Drawing.Point(43, 281);
            this.rbStandardRange.Name = "rbStandardRange";
            this.rbStandardRange.Size = new System.Drawing.Size(101, 17);
            this.rbStandardRange.TabIndex = 9;
            this.rbStandardRange.TabStop = true;
            this.rbStandardRange.Text = "Standard Colour";
            this.rbStandardRange.UseVisualStyleBackColor = true;
            // 
            // rbBespokeRange
            // 
            this.rbBespokeRange.AutoSize = true;
            this.rbBespokeRange.Location = new System.Drawing.Point(43, 304);
            this.rbBespokeRange.Name = "rbBespokeRange";
            this.rbBespokeRange.Size = new System.Drawing.Size(102, 17);
            this.rbBespokeRange.TabIndex = 10;
            this.rbBespokeRange.TabStop = true;
            this.rbBespokeRange.Text = "Bespoke Range";
            this.rbBespokeRange.UseVisualStyleBackColor = true;
            // 
            // lComponentsNeeded
            // 
            this.lComponentsNeeded.AutoSize = true;
            this.lComponentsNeeded.Location = new System.Drawing.Point(43, 353);
            this.lComponentsNeeded.Name = "lComponentsNeeded";
            this.lComponentsNeeded.Size = new System.Drawing.Size(112, 13);
            this.lComponentsNeeded.TabIndex = 11;
            this.lComponentsNeeded.Text = "Number of Componets";
            // 
            // tbNumComponents
            // 
            this.tbNumComponents.Location = new System.Drawing.Point(79, 370);
            this.tbNumComponents.Name = "tbNumComponents";
            this.tbNumComponents.Size = new System.Drawing.Size(41, 20);
            this.tbNumComponents.TabIndex = 12;
            this.tbNumComponents.TextChanged += new System.EventHandler(this.TbNumComponents_TextChanged);
            this.tbNumComponents.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbNumComponents_KeyPress);
            // 
            // lQuantity
            // 
            this.lQuantity.AutoSize = true;
            this.lQuantity.Location = new System.Drawing.Point(212, 280);
            this.lQuantity.Name = "lQuantity";
            this.lQuantity.Size = new System.Drawing.Size(46, 13);
            this.lQuantity.TabIndex = 14;
            this.lQuantity.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Finishing Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Number of Transfers";
            // 
            // tbNumTransfers
            // 
            this.tbNumTransfers.Location = new System.Drawing.Point(362, 189);
            this.tbNumTransfers.Name = "tbNumTransfers";
            this.tbNumTransfers.Size = new System.Drawing.Size(38, 20);
            this.tbNumTransfers.TabIndex = 21;
            this.tbNumTransfers.TextChanged += new System.EventHandler(this.TbAdditionalParts_TextChanged);
            this.tbNumTransfers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbAdditionalParts_KeyPress);
            // 
            // lDesignMould
            // 
            this.lDesignMould.AutoSize = true;
            this.lDesignMould.Location = new System.Drawing.Point(212, 316);
            this.lDesignMould.Name = "lDesignMould";
            this.lDesignMould.Size = new System.Drawing.Size(135, 13);
            this.lDesignMould.TabIndex = 23;
            this.lDesignMould.Text = "Design and Mould Creation";
            // 
            // cbMoulds
            // 
            this.cbMoulds.AllowDrop = true;
            this.cbMoulds.FormattingEnabled = true;
            this.cbMoulds.Items.AddRange(new object[] {
            "New Mould Required",
            "Mould Already Avalible"});
            this.cbMoulds.Location = new System.Drawing.Point(215, 332);
            this.cbMoulds.Name = "cbMoulds";
            this.cbMoulds.Size = new System.Drawing.Size(132, 21);
            this.cbMoulds.TabIndex = 22;
            // 
            // bCalculate
            // 
            this.bCalculate.Location = new System.Drawing.Point(26, 418);
            this.bCalculate.Name = "bCalculate";
            this.bCalculate.Size = new System.Drawing.Size(129, 52);
            this.bCalculate.TabIndex = 24;
            this.bCalculate.Text = "Calculate";
            this.bCalculate.UseVisualStyleBackColor = true;
            this.bCalculate.Click += new System.EventHandler(this.BCalculate_Click_1);
            // 
            // bSaveQuote
            // 
            this.bSaveQuote.Location = new System.Drawing.Point(161, 418);
            this.bSaveQuote.Name = "bSaveQuote";
            this.bSaveQuote.Size = new System.Drawing.Size(239, 52);
            this.bSaveQuote.TabIndex = 26;
            this.bSaveQuote.Text = "Save Quote";
            this.bSaveQuote.UseVisualStyleBackColor = true;
            this.bSaveQuote.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Additional weight";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(136, 78);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(52, 20);
            this.tbWeight.TabIndex = 30;
            this.tbWeight.TextChanged += new System.EventHandler(this.TbAdditionalWeight_TextChanged);
            this.tbWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbWeight_KeyPress);
            // 
            // cbFettling
            // 
            this.cbFettling.AutoSize = true;
            this.cbFettling.Location = new System.Drawing.Point(239, 97);
            this.cbFettling.Name = "cbFettling";
            this.cbFettling.Size = new System.Drawing.Size(60, 17);
            this.cbFettling.TabIndex = 31;
            this.cbFettling.Text = "Fettling";
            this.cbFettling.UseVisualStyleBackColor = true;
            // 
            // cbHandPainting
            // 
            this.cbHandPainting.AutoSize = true;
            this.cbHandPainting.Location = new System.Drawing.Point(239, 120);
            this.cbHandPainting.Name = "cbHandPainting";
            this.cbHandPainting.Size = new System.Drawing.Size(146, 17);
            this.cbHandPainting.TabIndex = 32;
            this.cbHandPainting.Text = "Hand Painting(per colour)";
            this.cbHandPainting.UseVisualStyleBackColor = true;
            // 
            // cbTransfersUsed
            // 
            this.cbTransfersUsed.AutoSize = true;
            this.cbTransfersUsed.Location = new System.Drawing.Point(238, 169);
            this.cbTransfersUsed.Name = "cbTransfersUsed";
            this.cbTransfersUsed.Size = new System.Drawing.Size(137, 17);
            this.cbTransfersUsed.TabIndex = 33;
            this.cbTransfersUsed.Text = "Transfers (per transfers)";
            this.cbTransfersUsed.UseVisualStyleBackColor = true;
            // 
            // tbNumColoursUsed
            // 
            this.tbNumColoursUsed.Location = new System.Drawing.Point(371, 143);
            this.tbNumColoursUsed.Name = "tbNumColoursUsed";
            this.tbNumColoursUsed.Size = new System.Drawing.Size(38, 20);
            this.tbNumColoursUsed.TabIndex = 35;
            this.tbNumColoursUsed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbNumColoursUsed_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Number of Colours used";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(264, 275);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(38, 20);
            this.tbQuantity.TabIndex = 36;
            this.tbQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbQuantity_KeyPress);
            // 
            // labelFinalPrice
            // 
            this.labelFinalPrice.AutoSize = true;
            this.labelFinalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFinalPrice.Location = new System.Drawing.Point(218, 395);
            this.labelFinalPrice.Name = "labelFinalPrice";
            this.labelFinalPrice.Size = new System.Drawing.Size(71, 13);
            this.labelFinalPrice.TabIndex = 37;
            this.labelFinalPrice.Text = "Final Price:";
            // 
            // tbfinalPrice
            // 
            this.tbfinalPrice.Location = new System.Drawing.Point(295, 392);
            this.tbfinalPrice.Name = "tbfinalPrice";
            this.tbfinalPrice.ReadOnly = true;
            this.tbfinalPrice.Size = new System.Drawing.Size(105, 20);
            this.tbfinalPrice.TabIndex = 38;
            // 
            // cbPartsAssembly
            // 
            this.cbPartsAssembly.AutoSize = true;
            this.cbPartsAssembly.Location = new System.Drawing.Point(238, 215);
            this.cbPartsAssembly.Name = "cbPartsAssembly";
            this.cbPartsAssembly.Size = new System.Drawing.Size(109, 17);
            this.cbPartsAssembly.TabIndex = 42;
            this.cbPartsAssembly.Text = "Assembly of Parts";
            this.cbPartsAssembly.UseVisualStyleBackColor = true;
            // 
            // tbNumParts
            // 
            this.tbNumParts.Location = new System.Drawing.Point(350, 230);
            this.tbNumParts.Name = "tbNumParts";
            this.tbNumParts.Size = new System.Drawing.Size(38, 20);
            this.tbNumParts.TabIndex = 44;
            this.tbNumParts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbNumParts_KeyPress);
            this.tbNumParts.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TbNumParts_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Number Of Parts";
            // 
            // mtbDate
            // 
            this.mtbDate.Location = new System.Drawing.Point(295, 26);
            this.mtbDate.Name = "mtbDate";
            this.mtbDate.Size = new System.Drawing.Size(80, 20);
            this.mtbDate.TabIndex = 45;
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(122, 476);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(278, 20);
            this.tbFilePath.TabIndex = 47;
            this.tbFilePath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilePath_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "File Path:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 511);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mtbDate);
            this.Controls.Add(this.tbNumParts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbPartsAssembly);
            this.Controls.Add(this.tbfinalPrice);
            this.Controls.Add(this.labelFinalPrice);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.tbNumColoursUsed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTransfersUsed);
            this.Controls.Add(this.cbHandPainting);
            this.Controls.Add(this.cbFettling);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bSaveQuote);
            this.Controls.Add(this.bCalculate);
            this.Controls.Add(this.lDesignMould);
            this.Controls.Add(this.cbMoulds);
            this.Controls.Add(this.tbNumTransfers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lQuantity);
            this.Controls.Add(this.tbNumComponents);
            this.Controls.Add(this.lComponentsNeeded);
            this.Controls.Add(this.rbBespokeRange);
            this.Controls.Add(this.rbStandardRange);
            this.Controls.Add(this.lProductColour);
            this.Controls.Add(this.lMaterial);
            this.Controls.Add(this.cbMaterialType);
            this.Controls.Add(this.lMouldingTech);
            this.Controls.Add(this.cbMouldingTechnique);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lName);
            this.MaximumSize = new System.Drawing.Size(433, 550);
            this.MinimumSize = new System.Drawing.Size(433, 550);
            this.Name = "Form1";
            this.Text = "Quote Calculator";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.ComboBox cbMouldingTechnique;
        private System.Windows.Forms.Label lMouldingTech;
        private System.Windows.Forms.Label lMaterial;
        private System.Windows.Forms.ComboBox cbMaterialType;
        private System.Windows.Forms.Label lProductColour;
        private System.Windows.Forms.RadioButton rbStandardRange;
        private System.Windows.Forms.RadioButton rbBespokeRange;
        private System.Windows.Forms.Label lComponentsNeeded;
        private System.Windows.Forms.TextBox tbNumComponents;
        private System.Windows.Forms.Label lQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumTransfers;
        private System.Windows.Forms.Label lDesignMould;
        private System.Windows.Forms.ComboBox cbMoulds;
        private System.Windows.Forms.Button bCalculate;
        private System.Windows.Forms.Button bSaveQuote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.CheckBox cbFettling;
        private System.Windows.Forms.CheckBox cbHandPainting;
        private System.Windows.Forms.CheckBox cbTransfersUsed;
        private System.Windows.Forms.TextBox tbNumColoursUsed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label labelFinalPrice;
        private System.Windows.Forms.TextBox tbfinalPrice;
        private System.Windows.Forms.CheckBox cbPartsAssembly;
        private System.Windows.Forms.TextBox tbNumParts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker mtbDate;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Label label6;
    }
}

