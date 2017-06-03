using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVVM_tutorial.MVVM_PatternVersion.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_tutorial.MVVM_PatternVersion.ViewModel.Tests
{
    [TestClass()]
    public class AccountCreationViewModelTests
    {
        [TestMethod()]
        public void Test_PasswordIsTooShort()
        {
            AccountCreationViewModel viewModel = new AccountCreationViewModel();
            viewModel.NewAccount.Password = "A1asd";
            viewModel.ValidatePassword();

            Assert.AreEqual("Password must be at least eight character long",
                viewModel.NewAccount.ValidationMassage);
        }

        [TestMethod()]
        public void Test_PasswordIsTooLong()
        {
            AccountCreationViewModel viewModel = new AccountCreationViewModel();
            viewModel.NewAccount.Password = "A1asdasdasdasdasdasdasdasdasdasdasdasd";
            viewModel.ValidatePassword();

            Assert.AreEqual("Password cannot be more than twenty character long",
                viewModel.NewAccount.ValidationMassage);
        }

        [TestMethod()]
        public void Test_PasswordWithoutUpperCaseCharacter()
        {
            AccountCreationViewModel viewModel = new AccountCreationViewModel();
            viewModel.NewAccount.Password = "1asdasdasd";
            viewModel.ValidatePassword();

            Assert.AreEqual("Password must contain at least one upper-case character",
                viewModel.NewAccount.ValidationMassage);
        }

        [TestMethod()]
        public void Test_PasswordWithoutLowerCaseCharacter()
        {
            AccountCreationViewModel viewModel = new AccountCreationViewModel();
            viewModel.NewAccount.Password = "1ASDASDASD";
            viewModel.ValidatePassword();

            Assert.AreEqual("Password must contain at least one lower-case character",
                viewModel.NewAccount.ValidationMassage);
        }

        [TestMethod()]
        public void Test_PasswordWithoutNumber()
        {
            AccountCreationViewModel viewModel = new AccountCreationViewModel();
            viewModel.NewAccount.Password = "asdASDASDASD";
            viewModel.ValidatePassword();

            Assert.AreEqual("Password must contain at least one number",
                viewModel.NewAccount.ValidationMassage);
        }

        [TestMethod()]
        public void Test_PasswordIsSecure()
        {
            AccountCreationViewModel viewModel = new AccountCreationViewModel();
            viewModel.NewAccount.Password = "123asdASDASDASD";
            viewModel.ValidatePassword();

            Assert.AreEqual("Password is secure",
                viewModel.NewAccount.ValidationMassage);
        }
    }
}