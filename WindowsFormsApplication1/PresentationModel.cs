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
        private bool isRegisterButtonEnable = true;
        

        private string idText = "";
        private string nickNameText = "";

        #region Properties

        public string NickNameText
        {
            get { return nickNameText; }
            set { nickNameText = value; }
        }

        public string IdText
        {
            get { return idText; }
            set { idText = value; }
        }
        public bool IsRegisterButtonEnable
        {
            get { return isRegisterButtonEnable; }
            set { isRegisterButtonEnable = value; }
        }

        #endregion

        public PresentationModel(Model model)
        {
            _model = model;
        }

        public void Init()
        {
            string id = "";
            if(_model.IsRegister(out id))
            _model.Init();
        }
        public void IsRegister()
        {
            if (_model.IsRegister(out idText))
            {
                isRegisterButtonEnable = false;
            }
            else isRegisterButtonEnable = true;
        }
    }
}
