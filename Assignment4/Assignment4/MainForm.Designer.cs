//By Anton Forsberg
namespace Assignment4
{
    partial class MainForm
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
            this.rbtnReserve = new System.Windows.Forms.RadioButton();
            this.rbtnCancel = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblTotSeats = new System.Windows.Forms.Label();
            this.lblRsrvSeats = new System.Windows.Forms.Label();
            this.lblVacSeats = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.grpReservations = new System.Windows.Forms.GroupBox();
            this.lstSeats = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.grpReservations.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnReserve
            // 
            this.rbtnReserve.AutoSize = true;
            this.rbtnReserve.Location = new System.Drawing.Point(16, 30);
            this.rbtnReserve.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnReserve.Name = "rbtnReserve";
            this.rbtnReserve.Size = new System.Drawing.Size(82, 21);
            this.rbtnReserve.TabIndex = 0;
            this.rbtnReserve.TabStop = true;
            this.rbtnReserve.Text = "Reserve";
            this.rbtnReserve.UseVisualStyleBackColor = true;
            this.rbtnReserve.CheckedChanged += new System.EventHandler(this.rbtnReserve_CheckedChanged);
            // 
            // rbtnCancel
            // 
            this.rbtnCancel.AutoSize = true;
            this.rbtnCancel.Location = new System.Drawing.Point(137, 30);
            this.rbtnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnCancel.Name = "rbtnCancel";
            this.rbtnCancel.Size = new System.Drawing.Size(152, 21);
            this.rbtnCancel.TabIndex = 1;
            this.rbtnCancel.TabStop = true;
            this.rbtnCancel.Text = "Cancel Reservation";
            this.rbtnCancel.UseVisualStyleBackColor = true;
            this.rbtnCancel.CheckedChanged += new System.EventHandler(this.rbtnCancel_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.AccessibleDescription = "";
            this.txtName.Location = new System.Drawing.Point(16, 76);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(159, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(184, 76);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(109, 22);
            this.txtPrice.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 57);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Price";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(64, 113);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(176, 28);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblTotSeats
            // 
            this.lblTotSeats.AllowDrop = true;
            this.lblTotSeats.AutoSize = true;
            this.lblTotSeats.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotSeats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotSeats.Location = new System.Drawing.Point(244, 20);
            this.lblTotSeats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotSeats.Name = "lblTotSeats";
            this.lblTotSeats.Size = new System.Drawing.Size(48, 19);
            this.lblTotSeats.TabIndex = 7;
            this.lblTotSeats.Text = "label2";
            // 
            // lblRsrvSeats
            // 
            this.lblRsrvSeats.AutoSize = true;
            this.lblRsrvSeats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRsrvSeats.Location = new System.Drawing.Point(244, 48);
            this.lblRsrvSeats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRsrvSeats.Name = "lblRsrvSeats";
            this.lblRsrvSeats.Size = new System.Drawing.Size(48, 19);
            this.lblRsrvSeats.TabIndex = 8;
            this.lblRsrvSeats.Text = "label3";
            // 
            // lblVacSeats
            // 
            this.lblVacSeats.AutoSize = true;
            this.lblVacSeats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVacSeats.Location = new System.Drawing.Point(244, 78);
            this.lblVacSeats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVacSeats.Name = "lblVacSeats";
            this.lblVacSeats.Size = new System.Drawing.Size(48, 19);
            this.lblVacSeats.TabIndex = 9;
            this.lblVacSeats.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total number of seats";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Number of reserved seats";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 78);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Number of vacant seats";
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.btnOk);
            this.grpInput.Location = new System.Drawing.Point(1, 4);
            this.grpInput.Margin = new System.Windows.Forms.Padding(4);
            this.grpInput.Name = "grpInput";
            this.grpInput.Padding = new System.Windows.Forms.Padding(4);
            this.grpInput.Size = new System.Drawing.Size(311, 149);
            this.grpInput.TabIndex = 14;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Booking Input";
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.label7);
            this.grpOutput.Controls.Add(this.lblTotSeats);
            this.grpOutput.Controls.Add(this.lblRsrvSeats);
            this.grpOutput.Controls.Add(this.lblVacSeats);
            this.grpOutput.Controls.Add(this.label5);
            this.grpOutput.Controls.Add(this.label6);
            this.grpOutput.Location = new System.Drawing.Point(1, 160);
            this.grpOutput.Margin = new System.Windows.Forms.Padding(4);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Padding = new System.Windows.Forms.Padding(4);
            this.grpOutput.Size = new System.Drawing.Size(311, 146);
            this.grpOutput.TabIndex = 15;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output Data";
            // 
            // grpReservations
            // 
            this.grpReservations.Controls.Add(this.lstSeats);
            this.grpReservations.Controls.Add(this.label8);
            this.grpReservations.Controls.Add(this.label4);
            this.grpReservations.Controls.Add(this.label3);
            this.grpReservations.Controls.Add(this.label2);
            this.grpReservations.Location = new System.Drawing.Point(320, 4);
            this.grpReservations.Margin = new System.Windows.Forms.Padding(4);
            this.grpReservations.Name = "grpReservations";
            this.grpReservations.Padding = new System.Windows.Forms.Padding(4);
            this.grpReservations.Size = new System.Drawing.Size(491, 303);
            this.grpReservations.TabIndex = 16;
            this.grpReservations.TabStop = false;
            this.grpReservations.Text = "Reservations";
            // 
            // lstSeats
            // 
            this.lstSeats.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSeats.FormattingEnabled = true;
            this.lstSeats.HorizontalScrollbar = true;
            this.lstSeats.ItemHeight = 17;
            this.lstSeats.Location = new System.Drawing.Point(13, 52);
            this.lstSeats.Margin = new System.Windows.Forms.Padding(4);
            this.lstSeats.Name = "lstSeats";
            this.lstSeats.ScrollAlwaysVisible = true;
            this.lstSeats.Size = new System.Drawing.Size(468, 225);
            this.lstSeats.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Seat";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 318);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.rbtnCancel);
            this.Controls.Add(this.rbtnReserve);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpReservations);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Cinema Booking System 2.0";
            this.grpInput.ResumeLayout(false);
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.grpReservations.ResumeLayout(false);
            this.grpReservations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnReserve;
        private System.Windows.Forms.RadioButton rbtnCancel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblTotSeats;
        private System.Windows.Forms.Label lblRsrvSeats;
        private System.Windows.Forms.Label lblVacSeats;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.GroupBox grpReservations;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstSeats;

    }
}

