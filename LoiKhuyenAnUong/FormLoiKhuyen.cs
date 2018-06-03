using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoiKhuyenAnUong
{
    public partial class FormLoiKhuyen : Form
    {
        String AnKieng_VanPhong = "Nhân viên văn phòng là công việc có tính chất đặc thù ít vận động, công việc nhẹ nhàng nên không cần sử dụng quá nhiều năng lượng, hơn nữa thời gian làm việc khá nhàn rỗi nên thường có thói quen ăn vặt. Đó cũng là nguyên nhân khiến nguy cơ bị thừa cân ở những người làm công việc này rất cao, thậm chí đến mức báo động. Đặc biệt việc giảm cân ở đối tượng này tương đối khó.Muốn việc giảm cân được thành công, trước hết bạn phải nắm rõ bản chất và nguyên tắc của vấn đề. Cụ thể là: năng lượng được cung cấp vào phải thấp hơn năng lương tiêu hao thì việc giảm cân mới thành công, trong đó giảm ăn hoặc tăng vận động là hai phương pháp được áp dụng.Nên giảm xuống mức thấp nhất có thể lượng cơm ăn hàng ngày. Chẳng hạn bình thường mỗi ngày ăn 3 bát thì giờ giảm xuống còn 1-1,5 bát và nên tập trung ăn vào sáng hoặc trưa, chỉ ăn nửa bát vào buổi tối. Riêng các loại fastfood, bánh mỳ kẹp tuyệt đối không nên ăn.";
        String AnKieng_LDNhe = "Mỗi bữa nên cách nhau khoảng 3 giờ, tổng cộng 5-8 bữa ăn nhỏ mỗi ngày. Duy trì ăn đều đặn như thế. Việc chia nhỏ bữa ăn sẽ đảm bảo rằng dạ dày của bạn luôn no. Vì vậy, sẽ không còn cảm giác thèm ăn! Bạn có thể bổ sung các loại hạt chứa nhiều protein và tốt cho sức khỏe như hạt điều, hạnh nhân, maccadamia cho những buổi ăn nhẹ của mình.Dung nạp lượng protein đầy đủ và thích hợp trong chế độ ăn là điều thiết yếu. Điều đó rất quan trọng để có mái tóc bóng khỏe, tăng hàm lượng hemoglobin, nhanh lành sẹo và đặc biệt là thúc đẩy quá trình xây dựng các khối cơ của phái mạnh.Rau, củ, trái cây là những thực phẩm lành mạnh. Chúng giúp cung cấp nguồn năng lượng thiết yếu để hoạt động. Ăn nhiều rau, quả giúp cơ thể tránh được các bệnh về tim, ổn định huyết áp và ngăn ngừa một số bệnh ung thư, hạn chế hiệu quả các bệnh liên quan đến đường ruột đặc biệt là viêm ruột thừa, bảo vệ mắt khỏi bị 2 loại bệnh thoái hóa rất phổ biến, đó là đục nhân mắt và chấm đen trong mắt…";
        String AnKieng_LDNang = "Mặc dù nghe qua có vẻ không hợp lý nhưng không phải không có trường hợp người lao động nặng vẫn thừa cân vì họ có 1 chế độ ăn không hợp lý.Một số người nghĩ rằng bỏ bữa ăn sẽ giúp họ giảm cân, nhưng nó được chứng minh ăn thường xuyên trong ngày giúp đốt cháy calo với một tốc độ nhanh hơn. Nó cũng làm giảm sự cám dỗ để ăn nhẹ các loại thực phẩm giàu chất béo và đường. Cơ thể chúng ta chiếm hơn 70% là nước, vì vậy nước cực kỳ quan trọng trong sự phát triển của cơ thể. Và thiếu hụt nước sẽ làm ảnh hưởng nghiêm trọng với sức khỏe. Nước có khẳ năng làm tăng sự trao đổi chất, và thật tuyệt vời khi nước có khả năng tăng đốt cháy calo, giảm cảm giác thèm ăn, cơ thể tràn trề sức sống. Và bây giờ chúng ta phải tận dụng sức mạnh của nước để hổ trợ giảm cân.Và biết làm thế nào để xem thành phần thực phẩm có thể giúp bạn lựa chọn thực phẩm lành mạnh hơn, và giữ một kiểm tra lượng calo, chất béo, muối và đường ăn. Sử dụng thông tin calorie trên bao bì để ước tính được calo bạn đang tiêu thụ.";
        String TangCan_VanPhong = "Bạn có thể dùng dùng công cụ sau để tính lượng calo mình cần để tăng cân: Công cụ tính lượng calo cần để tăng cân. Trung bình lượng calo hàng ngày cho một nam giới khoảng 2000-2200 calo; đối với nữ, khoảng 1700-1900.  Bạn cần ăn thêm 1100 calo hàng ngày so với lượng calo cần để giữ cân để tăng 1 kg mỗi tuần.Ăn thức ăn có nhiều protein như rau đậu, và thức ăn có nhiều tinh bột như khoai tây, gạoĂn nhẹ/vặt những loại thức ăn nhiều calo (nhưng không có hại) như phô mai, sữa, hoa quả khô, sữa chua.Tập aerobic rất tốt, phải không? Nhưng không phải để tăng cân. Bạn cần những bài tập rất nặng và cường độ cao để tăng cơ (ví dụ Hiit, tập tạ).Bạn cũng nên tăng khẩu phần ăn của mình nếu muốn  tăng cân. Theo kinh nghiệm của những người đã tăng cân thành công, bạn đừng nên ép buộc mình ăn quá nhiều  cùng một lúc, hãy chia nhỏ bữa ăn trong ngày thành 5 – 6 bữa ăn với đầy đủ calo, protein, chất béo, khoáng chất và vitamin…để tăng cân lành mạnh.";
        String TangCan_LDNhe = "Giữ một tạp chí thực phẩm sẽ cho phép bạn theo dõi sự tăng cân của mình và cho phép bạn xem các phương pháp có làm việc hiệu quả hay không.Hãy ghi nhớ mỗi calo bạn tiêu thụ mỗi ngày và lượng calo bạn đốt cháy. Cũng ghi trọng lượng của bạn sau mỗi tuần.Xem những con số ghi sẽ giúp bạn tìm ra những gì bạn bạn đang làm là sai hay đúng, hoặc những gì bạn có thể cải thiện để tốt hơn.Nó cũng sẽ giúp giữ cho bạn có động cơ một khi bạn bắt đầu nhìn thấy sự tiến bộ. Và rong thực tế, việc tăng cân có thể là khó khăn hơn nhiều so với việc giảm cân . Tuy nhiên, điều quan trọng là bạn luôn cam kết và giữ cho “đôi mắt” của bạn hướng đến mục đích của bản thân.Đặt mục tiêu nhỏ như đạt được 2 kg trong một tháng. Điều này sẽ cung cấp cho bạn một cái gì đó hữu hình hơn để hướng tới.Nếu bạn đặt ra mục tiêu của bạn quá cao, thật dễ dàng để trở nên quá tải và cảm thấy muốn bỏ cuộc.";
        String TangCan_LDNang = "Yếu tố đầu tiên và cũng là quan trọng nhất để cải thiện cân nặng của người gầy đó chính là ăn uống. Việc ăn uống sẽ liên quan mật thiết đến việc hấp thụ dinh dưỡng của cơ thể. Bởi nếu bạn ăn nhiều, cung cấp dinh dưỡng liên tục, uống sữa và ăn nhiều thực phẩm tốt nhưng bạn không thể hấp thụ chúng thì việc tăng cân cũng bằng không. Và ngược lại, bạn không thể cải thiện cân nặng nếu như không cung cấp đủ dinh dưỡng cho cơ thể.Do đó, muốn tăng cân nhanh, bạn phải chắc chắn rằng, mình nạp hơn 2000 calo mỗi ngày, đồng thời, cơ thể phải luôn đảm bảo việc hấp thụ dưỡng chất ở mức cao nhất.Ngoài 3 bữa chính, người gầy nên ăn thêm 2 đến 3 bữa phụ nếu như muốn đẩy nhanh tốc độ tăng cân của mình. Bữa phụ sẽ giúp cơ thể nhận được nguồn dinh dưỡng một cách liên tục. Những thực phẩm nên hấp thụ trong những bữa ăn này bao gồm: Sữa, sinh tố, bánh ngọt, nước ép, phô mai, các loại hạt.Thiếu ngủ cùng một loạt các hậu quả của nó như stress, căng thẳng, mệt mỏi, trầm cảm là nguyên nhân khiến chúng ta rất khó để tăng cân. Để có được cân nặng mong muốn trong một thời gian ngắn, các bạn nhất thiết phải ngủ đủ giấc với 7 – 8 tiếng mỗi ngày. Đặc biệt, chúng mình cũng cần quan tâm hơn đến chất lượng giấc ngủ. Các bạn có thể uống một cốc nước ấm trước khi đi ngủ để ngủ ngon hơn. Ngoài ra, bạn cũng nên tạo cho mình một không gian thoáng đãng, tránh ánh sáng để có giấc ngủ sâu hơn. Và cuối cùng Đây là các thói quen gây ảnh hưởng rất lớn đến sự tăng cân của chúng ta. Vì thế, nếu bạn mắc phải các thói quen xấu này thì hãy loại bỏ ngay nhé!+ Thường xuyên uống rượu, bia, hút thuốc lá là thói quen khiến chúng ta mất cảm giác thèm ăn, vì vậy mà ăn ít hơn nên không thể tăng cân.Hay thức khuya sẽ khiến bạn bị mệt mỏi, chán ăn, suy nhược cơ thể…Ăn quá nhanh, nhai không kỹ cũng là “thủ phạm” khiến cân nặng khó dịch chuyển bởi điều này làm cho thức ăn không được tiêu hóa . Vì thế, cơ thể dễ rơi vào tình trạng thiếu dinh dưỡng và rất khó để tăng cân.";
   
        public FormLoiKhuyen()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            lbLoiKhuyen.Visible = true;
            String CheDo = cbxCheDo.GetItemText(cbxCheDo.SelectedItem);
            String ankieng = "Ăn kiêng";
            String tangcan = "Tăng cân";

            String NgheNghiep = cbxNgheNghiep.GetItemText(cbxNgheNghiep.SelectedItem);
            String vanphong = "Nhân viên văn phòng";
            String ldnhe = "Lao động nhẹ";
            String ldnang = "Lao động nặng";

            if (String.Compare(CheDo, ankieng) == 0 && String.Compare(NgheNghiep, vanphong) == 0)
            {
                lbLoiKhuyen.Text = AnKieng_VanPhong;
            }

            if (String.Compare(CheDo, ankieng) == 0 && String.Compare(NgheNghiep, ldnhe) == 0)
            {
                lbLoiKhuyen.Text = AnKieng_LDNhe;
            }

            if (String.Compare(CheDo, ankieng) == 0 && String.Compare(NgheNghiep, ldnang) == 0)
            {
                lbLoiKhuyen.Text = AnKieng_LDNang;
            }

            if (String.Compare(CheDo, tangcan) == 0 && String.Compare(NgheNghiep, vanphong) == 0)
            {
                lbLoiKhuyen.Text = TangCan_VanPhong;
            }

            if (String.Compare(CheDo, tangcan) == 0 && String.Compare(NgheNghiep, ldnhe) == 0)
            {
                lbLoiKhuyen.Text = TangCan_LDNhe;
            }

            if (String.Compare(CheDo, tangcan) == 0 && String.Compare(NgheNghiep, ldnang) == 0)
            {
                lbLoiKhuyen.Text = TangCan_LDNang;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }

        private void cbxCheDo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
