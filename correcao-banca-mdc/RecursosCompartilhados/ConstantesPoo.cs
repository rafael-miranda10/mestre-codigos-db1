﻿namespace RecursosCompartilhados
{
    public class ConstantesPoo
    {
        #region Conceitos POO
        public const string NomeQuadrado = "Quadrado";
        public const string NomeCirculo = "Círculo";
        public const string NomeRetangulo = "Retângulo";
        public const string NomeTriangulo = "Triângulo";
        public const string MsgExibirForma = "A área do {0} é: {1}";

        public const string MsgDescartavelMetodoChamado = "Método dispose chamado!";
        public const string MsgDescartavelExecutarAlgo = "Execução de métodos da classe e consumindo instância do objeto!\n";
        public const string MsgEmpregadoString = "O salário de: {0} é de: {1}";

        public const string EmpregadoRafael = "Rafael";
        public const string EmpregadoDjalmaJorge = "Djalma Jorge";
        public const string EmpregadoTiringa = "Tiringa";
        public const string EmpregadoZobaido = "Zobaido";
        public const string EmpregadoAna = "Ana";

        public const string TelefoneHumano = "(18) 99654-8521";
        public const string NomeHumano = "Valdomiro Miranda";
        public const string NomeHumanoClonado = "Osvaldo de Oliveira";
        public const string DadosHumano = "Nome: {0} - Idade: {1} - Telefone: {2}";

        public const string CachorroNomeGreg = "Greg";
        public const string CachorroRacGreg = "Shitzu";
        public const string CachorroNomeBudy = "Budy";
        public const string CachorroRacaBudy = "Golden";
        public const string CachorroNomeThor = "Thor";
        public const string CachorroRacaThor = "PitBull";
        public const string DadosCachorro = "Nome do cachorro: {0}, raça do cachorro {1}";

        #endregion

        #region Representar Pessoa
        public const string ExibirDadosPessoa = "Nome: {0} possui a altura de: {1} metros, nascida em: {2} com {3} anos de idade.";
        public const string MsgErroValidacaoPessoa = "Dados da pessoa incorretos! Volte ao menu e insira novamente!";
        public const string MsgPessoaNaoNasceu = " A pessoa ainda não nasceu!";
        #endregion

        #region Conta Bancaria
        public const string MsgDadosContaCorrente = "A conta corrente de número: {0} possui o saldo de : {1}";
        public const string MsgDadosContaEspecial = "A conta especial de número: {0} possui o saldo de : {1}";
        public const string MsgSemSaldoContaBancaria = "A conta {0} de número: {1} não possui o saldo suficiente para o saque de R$: {2}";
        public const string MsgBancoInformeValorDeposito = "Informe o valor do depósito: ";
        public const string MsgBancoInformeValorDeSaque = "Informe o valor do saque: ";
        public const string MsgBancoContaNaoExiste = "Não existe nenhum conta para ser exibida!";
        public const string MsgBancoOperacaoSucesso = "Operação realizada! Por favor consulte o extrato!";
        public const string MsgBancoOperacaoPermitidaSucesso = "As operações de saque em contas cujo os saldos eram suficientes foram realizadas! Por favor consulte o extrato!";

        public const string MsgInformarNumeroContaCorrente = "Informe o número da conta corrente {0}: ";
        public const string MsgInformarSaldoContaCorrente = "Informe o saldo da conta corrente {0}: ";

        public const string MsgInformarNumeroContaEspecial = "Informe o número da conta especial {0}: ";
        public const string MsgInformarSaldoContaEspecial = "Informe o saldo da conta especial {0}: ";


        #endregion

        #region Controle remoto
        public const string MsgNaoEhPermitidoAumentarVolume = "Não é permitido aumentar o volume da televisão!";
        public const string MsgNaoEhPermitidoDiminuirVolume = "Não é permitido diminuir o volume da televisão!";
        public const string MsgVolumeAumentado = "Volume incrementado em uma unidade!";
        public const string MsgVolumeDiminuido = "Volume decrementado em uma unidade!";

        public const string MsgNaoEhPermitidoProximoCanal = "Não é permitido trocar para o próximo canal!";
        public const string MsgNaoEhPermitidoCanalAnterior = "Não é permitido trocar para o canal anterior!";
        public const string MsgProximoCanal= "Canal incrementado em uma unidade!";
        public const string MsgCanalAnterior = "Canal decrementado em uma unidade!";

        public const string MsgCanalEspecifico = "Informe o canal desejado: ";
        public const string MsgVolumeEspecifico = "Informe o volume desejado: ";
        public const string MsgErroCanalEspecifico = "Não é possível ir para o canal especifico!";

        public const string MsgEstadoControlavel = "A televisão está no canal {0} com o volume de som de {1}";
        public const string MsgNaoEhPossivelLigarControlavel = "Não é possivel ligar a televisão";
        public const string MsgControlavelDesligado = "A televisão está desligada!";
        #endregion
    }
}
