using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class PresentationModel
    {

        private Model _model;
        private bool _isRegisterButtonEnable = true;
        

        private string _idText = "";
        private string _nickNameText = "";
        private string _memberIdText = "";
        private bool _addButtonEnable = false;

        private List<string> _member = new List<string>();

        #region Properties

        public string NickNameText
        {
            get { return _nickNameText; }
            set { _nickNameText = value; }
        }

        public string IdText
        {
            get { return _idText; }
            set { _idText = value; }
        }
        public bool IsRegisterButtonEnable
        {
            get { return _isRegisterButtonEnable; }
            set { _isRegisterButtonEnable = value; }
        }

        #endregion

        public PresentationModel(Model model)
        {
            _model = model;
        }

        public void Init()
        {
            _model.Init();
            IsRegister();
        }

        public void Register()
        {
            int id = 0;
            _model.Register(_nickNameText, out id);
            _idText = id.ToString();
            //TODO(gca):model register here
        }

        public void CreateProject()
        {
            _model.CreateProject(Int32.Parse(_idText));
        }

        public void AddMember(int memberId)
        {
            if (_memberIdText == "")
            {
                _addButtonEnable = false;
                return;
            }
            else
            {
                _addButtonEnable = true;
                _model.AddMember(memberId);
                //TODO(gca): Refresh Listview
            }


        }

        /// <summary>
        /// 判斷是否有註冊過，註冊過將會更新ID跟NickName
        /// </summary>
        private void IsRegister()
        {
            //update idtext
            if (_model.IsRegister(out _idText, out _nickNameText))
            {
                _isRegisterButtonEnable = false;
                _nickNameText = _model.Database.GetNickName(_idText);
                //TODO(gca):need to update id and nick name 
            }
            else _isRegisterButtonEnable = true;
        }

        private void ShowProjectMember()
        {

        }

        

        
        
    }
}
