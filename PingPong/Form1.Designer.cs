
namespace PingPong
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel = new System.Windows.Forms.PictureBox();
            this.gamePanel = new System.Windows.Forms.PictureBox();
            this.gameBall = new System.Windows.Forms.PictureBox();
            this.result = new System.Windows.Forms.Label();
            this.losePanel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBall)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(857, 498);
            this.panel.TabIndex = 0;
            this.panel.TabStop = false;
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.Orange;
            this.gamePanel.Location = new System.Drawing.Point(340, 376);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(137, 38);
            this.gamePanel.TabIndex = 1;
            this.gamePanel.TabStop = false;
            // 
            // gameBall
            // 
            this.gameBall.BackColor = System.Drawing.Color.Blue;
            this.gameBall.Location = new System.Drawing.Point(84, 105);
            this.gameBall.Name = "gameBall";
            this.gameBall.Size = new System.Drawing.Size(50, 50);
            this.gameBall.TabIndex = 2;
            this.gameBall.TabStop = false;
            // 
            // result
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.result.AutoSize = true;
            this.result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(647, 32);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(182, 32);
            this.result.TabIndex = 3;
            this.result.Text = "Результат: 0";
            this.result.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // losePanel
            // 
            this.losePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.losePanel.AutoSize = true;
            this.losePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.losePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.losePanel.Location = new System.Drawing.Point(405, 194);
            this.losePanel.Name = "losePanel";
            this.losePanel.Size = new System.Drawing.Size(742, 113);
            this.losePanel.TabIndex = 4;
            this.losePanel.Text = "Вы проиграли!";
            this.losePanel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(857, 498);
            this.Controls.Add(this.losePanel);
            this.Controls.Add(this.result);
            this.Controls.Add(this.gameBall);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox panel;
        private System.Windows.Forms.PictureBox gamePanel;
        private System.Windows.Forms.PictureBox gameBall;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label losePanel;
    }
}

