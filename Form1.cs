namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        private int totalCost = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // 초기화 버튼 (btnlnt)
        private void btnlnt_Click(object sender, EventArgs e)
        {
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;
            lstOrder.Items.Clear();

            totalCost = 0;
            lblTotalCost.Text = "총 금액: 0원";
        }

        // 주문하기 버튼 (btnOrder)
        private void btnOrder_Click(object sender, EventArgs e)
        {
            // 주문 버튼을 누를 때마다 리스트와 금액을 초기화하고 다시 계산합니다.
            lstOrder.Items.Clear();
            totalCost = 0;

            // 1. 버거 선택 (Radio Button)
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

            // 2. 추가 옵션 선택 (Check Box)
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

            // 3. 최종 금액 출력 (천 단위 쉼표 적용)
            lblTotalCost.Text = "총 금액: " + totalCost.ToString("N0") + "원";

            // 4. 예외 처리 (버거를 선택하지 않은 경우)
            if (!rdoHamBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                lstOrder.Items.Clear();
                lstOrder.Items.Add("메뉴를 선택해주세요.");
                lblTotalCost.Text = "주문을 다시 확인해주세요.";
            }
        }

        private void lblTotalCost_Click(object sender, EventArgs e)
        {
            // 클릭 이벤트가 필요 없다면 비워두셔도 됩니다.
        }
    }
}
