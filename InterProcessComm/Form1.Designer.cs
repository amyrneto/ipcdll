namespace InterProcessComm
{
    partial class formIPC
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMemSizeAttribute = new System.Windows.Forms.TextBox();
            this.sharedMemoryAttributes = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnCreateSharedMemory = new System.Windows.Forms.Button();
            this.sharedMemoryDataFlow = new System.Windows.Forms.GroupBox();
            this.textBoxOffset = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSharedMemoryLabel = new System.Windows.Forms.Label();
            this.textBoxMemSizeDataBuffer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.sharedMemoryAttributes.SuspendLayout();
            this.sharedMemoryDataFlow.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // textBoxMemName
            // 
            this.textBoxMemName.Location = new System.Drawing.Point(50, 26);
            this.textBoxMemName.Name = "textBoxMemName";
            this.textBoxMemName.Size = new System.Drawing.Size(240, 20);
            this.textBoxMemName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size:";
            // 
            // textBoxMemSizeAttribute
            // 
            this.textBoxMemSizeAttribute.Location = new System.Drawing.Point(50, 52);
            this.textBoxMemSizeAttribute.Name = "textBoxMemSizeAttribute";
            this.textBoxMemSizeAttribute.Size = new System.Drawing.Size(240, 20);
            this.textBoxMemSizeAttribute.TabIndex = 3;
            // 
            // sharedMemoryAttributes
            // 
            this.sharedMemoryAttributes.Controls.Add(this.btnCreateSharedMemory);
            this.sharedMemoryAttributes.Controls.Add(this.lblStatus);
            this.sharedMemoryAttributes.Controls.Add(this.label3);
            this.sharedMemoryAttributes.Controls.Add(this.textBoxMemName);
            this.sharedMemoryAttributes.Controls.Add(this.textBoxMemSizeAttribute);
            this.sharedMemoryAttributes.Controls.Add(this.label1);
            this.sharedMemoryAttributes.Controls.Add(this.label2);
            this.sharedMemoryAttributes.Location = new System.Drawing.Point(12, 12);
            this.sharedMemoryAttributes.Name = "sharedMemoryAttributes";
            this.sharedMemoryAttributes.Size = new System.Drawing.Size(319, 161);
            this.sharedMemoryAttributes.TabIndex = 4;
            this.sharedMemoryAttributes.TabStop = false;
            this.sharedMemoryAttributes.Text = "Shared Memory Attributes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(55, 113);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(64, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Not Created";
            // 
            // btnCreateSharedMemory
            // 
            this.btnCreateSharedMemory.Location = new System.Drawing.Point(166, 103);
            this.btnCreateSharedMemory.Name = "btnCreateSharedMemory";
            this.btnCreateSharedMemory.Size = new System.Drawing.Size(127, 33);
            this.btnCreateSharedMemory.TabIndex = 6;
            this.btnCreateSharedMemory.Text = "Create";
            this.btnCreateSharedMemory.UseVisualStyleBackColor = true;
            this.btnCreateSharedMemory.Click += new System.EventHandler(this.btnCreateSharedMemory_Click);
            // 
            // sharedMemoryDataFlow
            // 
            this.sharedMemoryDataFlow.Controls.Add(this.btnWrite);
            this.sharedMemoryDataFlow.Controls.Add(this.btnRead);
            this.sharedMemoryDataFlow.Controls.Add(this.textBoxData);
            this.sharedMemoryDataFlow.Controls.Add(this.label9);
            this.sharedMemoryDataFlow.Controls.Add(this.textBoxMemSizeDataBuffer);
            this.sharedMemoryDataFlow.Controls.Add(this.label8);
            this.sharedMemoryDataFlow.Controls.Add(this.lblSharedMemoryLabel);
            this.sharedMemoryDataFlow.Controls.Add(this.textBoxOffset);
            this.sharedMemoryDataFlow.Controls.Add(this.label6);
            this.sharedMemoryDataFlow.Controls.Add(this.label7);
            this.sharedMemoryDataFlow.Location = new System.Drawing.Point(12, 179);
            this.sharedMemoryDataFlow.Name = "sharedMemoryDataFlow";
            this.sharedMemoryDataFlow.Size = new System.Drawing.Size(319, 184);
            this.sharedMemoryDataFlow.TabIndex = 7;
            this.sharedMemoryDataFlow.TabStop = false;
            this.sharedMemoryDataFlow.Text = "Shared Memory Data Flow";
            // 
            // textBoxOffset
            // 
            this.textBoxOffset.Location = new System.Drawing.Point(50, 56);
            this.textBoxOffset.Name = "textBoxOffset";
            this.textBoxOffset.Size = new System.Drawing.Size(251, 20);
            this.textBoxOffset.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Offset:";
            // 
            // lblSharedMemoryLabel
            // 
            this.lblSharedMemoryLabel.AutoSize = true;
            this.lblSharedMemoryLabel.Location = new System.Drawing.Point(50, 26);
            this.lblSharedMemoryLabel.Name = "lblSharedMemoryLabel";
            this.lblSharedMemoryLabel.Size = new System.Drawing.Size(140, 13);
            this.lblSharedMemoryLabel.TabIndex = 7;
            this.lblSharedMemoryLabel.Text = "Create New Shared Memory";
            // 
            // textBoxMemSizeDataBuffer
            // 
            this.textBoxMemSizeDataBuffer.Location = new System.Drawing.Point(50, 82);
            this.textBoxMemSizeDataBuffer.Name = "textBoxMemSizeDataBuffer";
            this.textBoxMemSizeDataBuffer.Size = new System.Drawing.Size(251, 20);
            this.textBoxMemSizeDataBuffer.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Size:";
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(50, 108);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(251, 20);
            this.textBoxData.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Data:";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(174, 134);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(127, 33);
            this.btnRead.TabIndex = 7;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(12, 134);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(127, 33);
            this.btnWrite.TabIndex = 12;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // formIPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 388);
            this.Controls.Add(this.sharedMemoryDataFlow);
            this.Controls.Add(this.sharedMemoryAttributes);
            this.Name = "formIPC";
            this.Text = "Inter Process Communication";
            this.sharedMemoryAttributes.ResumeLayout(false);
            this.sharedMemoryAttributes.PerformLayout();
            this.sharedMemoryDataFlow.ResumeLayout(false);
            this.sharedMemoryDataFlow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMemSizeAttribute;
        private System.Windows.Forms.GroupBox sharedMemoryAttributes;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCreateSharedMemory;
        private System.Windows.Forms.GroupBox sharedMemoryDataFlow;
        private System.Windows.Forms.TextBox textBoxOffset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSharedMemoryLabel;
        private System.Windows.Forms.TextBox textBoxMemSizeDataBuffer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
    }
}

