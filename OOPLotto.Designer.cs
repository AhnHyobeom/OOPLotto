
namespace OOPLotto
{
    partial class OOPLotto
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_buyMoney = new System.Windows.Forms.TextBox();
            this.btn_buyLotto = new System.Windows.Forms.Button();
            this.lb_buyLottos = new System.Windows.Forms.Label();
            this.rtb_lottos = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_jackpotLottos = new System.Windows.Forms.Button();
            this.tb_JackpotNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "구입 금액 입력 : ";
            // 
            // tb_buyMoney
            // 
            this.tb_buyMoney.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_buyMoney.Location = new System.Drawing.Point(240, 27);
            this.tb_buyMoney.Name = "tb_buyMoney";
            this.tb_buyMoney.Size = new System.Drawing.Size(266, 39);
            this.tb_buyMoney.TabIndex = 1;
            // 
            // btn_buyLotto
            // 
            this.btn_buyLotto.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_buyLotto.Location = new System.Drawing.Point(585, 27);
            this.btn_buyLotto.Name = "btn_buyLotto";
            this.btn_buyLotto.Size = new System.Drawing.Size(102, 39);
            this.btn_buyLotto.TabIndex = 2;
            this.btn_buyLotto.Text = "구입";
            this.btn_buyLotto.UseVisualStyleBackColor = true;
            this.btn_buyLotto.Click += new System.EventHandler(this.btn_buyLotto_Click);
            // 
            // lb_buyLottos
            // 
            this.lb_buyLottos.AutoSize = true;
            this.lb_buyLottos.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_buyLottos.Location = new System.Drawing.Point(202, 99);
            this.lb_buyLottos.Name = "lb_buyLottos";
            this.lb_buyLottos.Size = new System.Drawing.Size(355, 32);
            this.lb_buyLottos.TabIndex = 3;
            this.lb_buyLottos.Text = "구입한 로또 개수는 0개 입니다.";
            // 
            // rtb_lottos
            // 
            this.rtb_lottos.Font = new System.Drawing.Font("함초롬바탕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rtb_lottos.Location = new System.Drawing.Point(240, 162);
            this.rtb_lottos.Name = "rtb_lottos";
            this.rtb_lottos.Size = new System.Drawing.Size(529, 179);
            this.rtb_lottos.TabIndex = 4;
            this.rtb_lottos.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "구매한 로또 번호 : ";
            // 
            // btn_jackpotLottos
            // 
            this.btn_jackpotLottos.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_jackpotLottos.Location = new System.Drawing.Point(677, 380);
            this.btn_jackpotLottos.Name = "btn_jackpotLottos";
            this.btn_jackpotLottos.Size = new System.Drawing.Size(102, 39);
            this.btn_jackpotLottos.TabIndex = 8;
            this.btn_jackpotLottos.Text = "구입";
            this.btn_jackpotLottos.UseVisualStyleBackColor = true;
            this.btn_jackpotLottos.Click += new System.EventHandler(this.btn_jackpotLottos_Click);
            // 
            // tb_JackpotNumber
            // 
            this.tb_JackpotNumber.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_JackpotNumber.Location = new System.Drawing.Point(240, 378);
            this.tb_JackpotNumber.Name = "tb_JackpotNumber";
            this.tb_JackpotNumber.Size = new System.Drawing.Size(414, 39);
            this.tb_JackpotNumber.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(37, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "당첨 번호 입력 : ";
            // 
            // lb_result
            // 
            this.lb_result.AutoSize = true;
            this.lb_result.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_result.Location = new System.Drawing.Point(249, 477);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(240, 32);
            this.lb_result.TabIndex = 9;
            this.lb_result.Text = "수익률은 0% 입니다.";
            // 
            // OOPLotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.lb_result);
            this.Controls.Add(this.btn_jackpotLottos);
            this.Controls.Add(this.tb_JackpotNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtb_lottos);
            this.Controls.Add(this.lb_buyLottos);
            this.Controls.Add(this.btn_buyLotto);
            this.Controls.Add(this.tb_buyMoney);
            this.Controls.Add(this.label1);
            this.Name = "OOPLotto";
            this.Text = "LottoProgram";
            this.Load += new System.EventHandler(this.OOPLotto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_buyMoney;
        private System.Windows.Forms.Button btn_buyLotto;
        private System.Windows.Forms.Label lb_buyLottos;
        private System.Windows.Forms.RichTextBox rtb_lottos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_jackpotLottos;
        private System.Windows.Forms.TextBox tb_JackpotNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_result;
    }
}

