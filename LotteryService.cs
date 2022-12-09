using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLotto
{
    public class LotteryService
    {
        private int purchaseAmount = -1;
        private int purchaseCount = -1;
        private int lottoPrice = 1000;

        public LotteryService(string _purchaseAmount)
        {
            try
            {
                CreateLottoCount(_purchaseAmount);
            }
            catch (Exception ex)
            {

            }
        }

        public int getPurchasesCount()
        {
            return purchaseCount;
        }


        private void CreateLottoCount(string _purchaseAmount)
        {
            ValidatePurchases(_purchaseAmount);
            purchaseCount = DivideAmount();
        }

        private void ValidatePurchases(string _purchaseAmount)
        {
            if (!int.TryParse(_purchaseAmount, out purchaseAmount))
            {
                throw new InvalidCastException("올바른 형식의 구매금액을 입력해주세요.");
            }


            if (purchaseAmount % lottoPrice != 0)
            {
                throw new InvalidCastException("1000원 단위의 금액을 입력해주세요");
            }
        }

        private int DivideAmount()
        {
            return Convert.ToInt32(decimal.Divide(purchaseAmount, lottoPrice));
        }

        
    }

    public class LotteryGenerator
    {
        public LotteryGenerator()
        {

        }

        public LottoTicket CreateLottoTickets()
        {
            SortedSet<int> numbers = new SortedSet<int>();
            while (numbers.Count < CommDefine.LOTTO_NUMBER_SIZE)
            {
                numbers.Add(CommDefine.rnd.Next(CommDefine.LOTTO_RANDOM_START, CommDefine.LOTTO_RANDOM_END));
            }

            return new LottoTicket(numbers.ToList());
        }
    }

    public class LottoTickets
    {
        private List<LottoTicket> lottotickets;

        public LottoTickets(int _lottoPurchasesCount)
        {
            LotteryGenerator makeAutoNumber = new LotteryGenerator();

            lottotickets = new List<LottoTicket>();
            for(int i = 0; i < _lottoPurchasesCount; i++)
            {
                lottotickets.Add(makeAutoNumber.CreateLottoTickets());
            }
        }

        public string PrintLottoTickets()
        {
            return string.Join("\n", lottotickets.Select(x => x.PrintLottoTicket()).ToList());
        }
    }

    public class LottoTicket
    {
        private List<int> lottoNumbers;

        public LottoTicket(List<int> _lottoNumbers)
        {
            vaildateSize(_lottoNumbers);
            vaildateDuplicate(_lottoNumbers);
            lottoNumbers = _lottoNumbers;
        }

        private void vaildateSize(List<int> _lottoNumbers)
        {
            if(_lottoNumbers.Count() != CommDefine.LOTTO_NUMBER_SIZE)
            {
                throw new ArgumentException("로또 사이즈는 6개여야 합니다.");
            }
        }

        private void vaildateDuplicate(List<int> _lottoNumbers)
        {
            if(_lottoNumbers.HasDuplications())
            {
                throw new ArgumentException("로또 값은 중복 되지 않아야 합니다.");
            }
        }

        public string PrintLottoTicket()
        {
            return string.Join(", ", lottoNumbers);
        }
    }

    public class LotteryResultCheck
    {
        public LotteryResultCheck(LottoTickets _lottoPurchasesTicketList, string _jackPotNumbers)
        {
            ResultCheck(_lottoPurchasesTicketList, new LottoTicket(_jackPotNumbers.Split(',').Select(x => int.Parse(x)).ToList()));
        }


        private void ResultCheck(LottoTickets _lottoPurchasesTicketList, LottoTicket jackpotNumbers)
        {
            
        }
    }
}
