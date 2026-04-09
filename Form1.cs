
namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        private int totalCost = 0;

        public Form1()
        {
            InitializeComponent();

            // [과제3 설정] 
            this.AcceptButton = btnOrder;
            this.Load += (s, e) => rdoHamBurger.Focus();

            // [과제4 설정] 모든 선택 컨트롤에 "값이 바뀌면 즉시 업데이트" 이벤트 연결
            // 라디오 버튼
            rdoHamBurger.CheckedChanged += UpdateOrderInfo;
            rdoBulgogiBurger.CheckedChanged += UpdateOrderInfo;
            rdoChickenBurger.CheckedChanged += UpdateOrderInfo;

            // 체크 박스
            chkPotato.CheckedChanged += UpdateOrderInfo;
            chkCola.CheckedChanged += UpdateOrderInfo;
            chkCheese.CheckedChanged += UpdateOrderInfo;
            chkSauce.CheckedChanged += UpdateOrderInfo;
        }

        // [과제4 핵심] 선택 시 즉시 리스트박스와 라벨을 갱신하는 메서드
        private void UpdateOrderInfo(object sender, EventArgs e)
        {
            // 리스트와 금액 초기화 후 다시 계산
            lstOrder.Items.Clear();
            totalCost = 0;

            // 1. 버거 선택 확인
            if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거: 5,000원");
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거: 4,000원");
            }
            else if (rdoChickenBurger.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거: 3,000원");
            }

            // 2. 추가 옵션 선택 확인
            if (chkPotato.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김: 3,500원");
            }
            if (chkCola.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라: 2,500원");
            }
            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈: 1,500원");
            }
            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스: 500원");
            }

            // 3. 총 금액 즉시 갱신
            lblTotalCost.Text = "총 금액: " + totalCost.ToString("N0") + "원";

            // 4. 예외 처리 (아무것도 선택 안 했을 때)
            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                lstOrder.Items.Clear();
                lstOrder.Items.Add("메뉴를 선택해주세요.");
                lblTotalCost.Text = "주문을 시작해주세요.";
            }
        }

        // 초기화 버튼 (btnlnt)
        private void btnlnt_Click(object sender, EventArgs e)
        {
            // Checked를 false로 바꾸는 순간 UpdateOrderInfo가 자동으로 트리거됩니다.
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            rdoHamBurger.Focus();
        }

        // 주문하기 버튼 (btnOrder)
        private void btnOrder_Click(object sender, EventArgs e)
        {
            // 이미 실시간으로 리스트박스에 뜨고 있으므로 
            // 여기서는 최종 결제 완료 등의 로직만 처리하거나, 지금처럼 Update를 한 번 더 호출해도 됩니다.
            UpdateOrderInfo(null, null);
        }

        private void lblTotalCost_Click(object sender, EventArgs e)
        {
        }
    }
}