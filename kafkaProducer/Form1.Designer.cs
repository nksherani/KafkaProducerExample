namespace VD_Interview
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
            this.btnKafkanetSend = new System.Windows.Forms.Button();
            this.btnConfluentKafka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKafkanetSend
            // 
            this.btnKafkanetSend.Location = new System.Drawing.Point(542, 114);
            this.btnKafkanetSend.Name = "btnKafkanetSend";
            this.btnKafkanetSend.Size = new System.Drawing.Size(142, 23);
            this.btnKafkanetSend.TabIndex = 0;
            this.btnKafkanetSend.Text = "kafka-net send";
            this.btnKafkanetSend.UseVisualStyleBackColor = true;
            this.btnKafkanetSend.Click += new System.EventHandler(this.kafkanetSend_click);
            // 
            // btnConfluentKafka
            // 
            this.btnConfluentKafka.Location = new System.Drawing.Point(542, 182);
            this.btnConfluentKafka.Name = "btnConfluentKafka";
            this.btnConfluentKafka.Size = new System.Drawing.Size(142, 23);
            this.btnConfluentKafka.TabIndex = 1;
            this.btnConfluentKafka.Text = "Confluent Send";
            this.btnConfluentKafka.UseVisualStyleBackColor = true;
            this.btnConfluentKafka.Click += new System.EventHandler(this.confluentSend_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfluentKafka);
            this.Controls.Add(this.btnKafkanetSend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKafkanetSend;
        private System.Windows.Forms.Button btnConfluentKafka;
    }
}

