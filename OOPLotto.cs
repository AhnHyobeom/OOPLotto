using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPLotto
{
    public partial class OOPLotto : Form
    {
        private int lottoPurchaseCount = -1;
        LottoTickets lottoPurchaseTicketList;

        public OOPLotto()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 로또 구입 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_buyLotto_Click(object sender, EventArgs e)
        {
            PurchaseLotto();
            ShowPurchaseLottos();
        }

        private void ShowPurchaseLottos()
        {
            // 구매한 로또 목록 보여주기
            lottoPurchaseTicketList = new LottoTickets(lottoPurchaseCount);
            rtb_lottos.Text = lottoPurchaseTicketList.PrintLottoTickets();
        }

        private void PurchaseLotto()
        {
            // 로또 구매하기
            LotteryService _lottoShop;

            try
            {
                _lottoShop = new LotteryService(tb_buyMoney.Text);
            }
            catch (Exception ex)
            {
                MessageBoxShow(ex.Message);
                return;
            }

            lottoPurchaseCount = _lottoShop.getPurchasesCount();
            lb_buyLottos.Text = $"구입한 로또 개수는 {lottoPurchaseCount}개 입니다.";
            lb_buyLottos.Refresh();
        }

        /// <summary>
        /// 추첨 결과 출력 버튼 클릭 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_jackpotLottos_Click(object sender, EventArgs e)
        {
            if(lottoPurchaseCount < 1)
            {
                MessageBoxShow("1개 이상의 로또를 구입해 주세요");
                return;
            }


        }

        private void OOPLotto_Load(object sender, EventArgs e)
        {

        }

        private void MessageBoxShow(string message)
        {
            MessageBox.Show(message);
        }

    }
}
