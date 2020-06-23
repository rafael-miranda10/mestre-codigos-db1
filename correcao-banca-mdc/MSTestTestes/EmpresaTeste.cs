using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrabalhandoNoConsole._2_Empresa;

namespace MSTestTestes
{
    [TestClass]
    public class EmpresaTeste
    {
        private Empresa _empresa;
        private Funcionario _funcionario;

        private const string FUNC_NAME_VALIDO = "Rafael";
        private const string FUNC_NAME_INVALIDO_MIN = "Ra";
        private const string FUNC_NAME_INVALIDO_MAX = "RafaelRafaelRafaelRafaelRafaelRafaelRafaelRafaelRafael";
        private const double FUNC_SALARIO_VALIDO = 3560.90;
        private const double FUNC_SALARIO_INVALIDO = 0;
        private const int FUNC_QTDE_1 = 1;
        private const int FUNC_LISTA_VAZIA = 0;
        private const double FUNC_SALARIO_VALIDO_1 = 3560.90;
        private const double FUNC_SALARIO_VALIDO_2 = 987.12;
        private const double FUNC_SALARIO_VALIDO_3 = 2568.78;
        private const double FUNC_SALARIO_VALIDO_4 = 4852.10;
        private const double FUNC_SALARIO_VALIDO_5 = 3874.90;

        [TestInitialize]
        public void Init()
        {
            _empresa = new Empresa();
        }

        [TestMethod]
        public void AdicionaUmFuncionarioNaLista()
        {
            _empresa.AdicionarFuncionario(FUNC_NAME_VALIDO, FUNC_SALARIO_VALIDO);
            var qtde = _empresa.Funcionarios.Count;
            Assert.AreEqual(qtde, FUNC_QTDE_1);
        }

        [TestMethod]
        public void AdicionaUmFuncionarioNomeInvalidoMin()
        {
            _empresa.AdicionarFuncionario(FUNC_NAME_INVALIDO_MIN, FUNC_SALARIO_VALIDO);
            var qtde = _empresa.Funcionarios.Count;
            Assert.AreEqual(qtde, FUNC_LISTA_VAZIA);
        }

        [TestMethod]
        public void AdicionaUmFuncionarioNomeInvalidoMax()
        {
            _empresa.AdicionarFuncionario(FUNC_NAME_INVALIDO_MAX, FUNC_SALARIO_VALIDO);
            var qtde = _empresa.Funcionarios.Count;
            Assert.AreEqual(qtde, FUNC_LISTA_VAZIA);
        }

        [TestMethod]
        public void AdicionaUmFuncionarioSalarioInvalido()
        {
            _empresa.AdicionarFuncionario(FUNC_NAME_VALIDO, FUNC_SALARIO_INVALIDO);
            var qtde = _empresa.Funcionarios.Count;
            Assert.AreEqual(qtde, FUNC_LISTA_VAZIA);
        }

        [TestMethod]
        public void AdicionaUmFuncionarioValidoEOutroInvalido()
        {
            _empresa.AdicionarFuncionario(FUNC_NAME_VALIDO, FUNC_SALARIO_VALIDO);
            _empresa.AdicionarFuncionario(FUNC_NAME_INVALIDO_MAX, FUNC_SALARIO_VALIDO);
            var qtde = _empresa.Funcionarios.Count;
            Assert.AreEqual(qtde, FUNC_QTDE_1);
        }

        [TestMethod]
        public void FuncionarioValido()
        {
            _funcionario = new Funcionario(FUNC_NAME_VALIDO, FUNC_SALARIO_VALIDO);
            Assert.IsTrue(_funcionario.Valid);
        }

        [TestMethod]
        public void FuncionarioInvalido()
        {
            _funcionario = new Funcionario(FUNC_NAME_INVALIDO_MAX, FUNC_SALARIO_INVALIDO);
            Assert.IsFalse(_funcionario.Valid);
        }

        [TestMethod]
        public void PosicaoMaiorEMenorFor()
        {
            // Menor posicao = 2 e maior = 4
            _empresa.AdicionarFuncionario(FUNC_NAME_VALIDO, FUNC_SALARIO_VALIDO_1);
            _empresa.AdicionarFuncionario(FUNC_NAME_VALIDO, FUNC_SALARIO_VALIDO_3);
            _empresa.AdicionarFuncionario(FUNC_NAME_VALIDO, FUNC_SALARIO_VALIDO_2);
            _empresa.AdicionarFuncionario(FUNC_NAME_VALIDO, FUNC_SALARIO_VALIDO_5);
            _empresa.AdicionarFuncionario(FUNC_NAME_VALIDO, FUNC_SALARIO_VALIDO_4);
            _empresa.ExibirMaiorMenorComFor();
            Assert.AreEqual(_empresa.PosMenor, 2);
            Assert.AreEqual(_empresa.PosMaior, 4);
        }
        [TestMethod]
        public void PosicaoMaiorEMenorWhile()
        {
            // Menor posicao = 4 e maior = 1
            _empresa.AdicionarFuncionario(FUNC_NAME_VALIDO, FUNC_SALARIO_VALIDO_1);
            _empresa.AdicionarFuncionario(FUNC_NAME_VALIDO, FUNC_SALARIO_VALIDO_4);
            _empresa.AdicionarFuncionario(FUNC_NAME_VALIDO, FUNC_SALARIO_VALIDO_3);
            _empresa.AdicionarFuncionario(FUNC_NAME_VALIDO, FUNC_SALARIO_VALIDO_5);
            _empresa.AdicionarFuncionario(FUNC_NAME_VALIDO, FUNC_SALARIO_VALIDO_2);
            _empresa.ExibirMaiorMenorComWhile();
            Assert.AreEqual(_empresa.PosMenor, 4);
            Assert.AreEqual(_empresa.PosMaior, 1);
        }

        [TestMethod]
        public void PosicaoMaiorEMenorBubbleSort()
        {
            _empresa.AdicionarFuncionario(FUNC_NAME_VALIDO, FUNC_SALARIO_VALIDO_1);
            _empresa.AdicionarFuncionario(FUNC_NAME_VALIDO, FUNC_SALARIO_VALIDO_4);
            _empresa.AdicionarFuncionario(FUNC_NAME_VALIDO, FUNC_SALARIO_VALIDO_3);
            _empresa.AdicionarFuncionario(FUNC_NAME_VALIDO, FUNC_SALARIO_VALIDO_5);
            _empresa.AdicionarFuncionario(FUNC_NAME_VALIDO, FUNC_SALARIO_VALIDO_2);
            _empresa.ExibirMaiorMenorComOrdencaoBolha();
            Assert.AreEqual(_empresa.PosMenor, 0);
            Assert.AreEqual(_empresa.PosMaior, _empresa.Funcionarios.Count - 1);
        }

    }
}
