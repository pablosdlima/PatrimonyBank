const addId = document.querySelector('#addId');
const cpfId = document.querySelector('#cpfId');
const cnpjId = document.querySelector('#cnpjId');

const InserirCPF = () => {
    addId.style.display = "none";
    cpfId.style.display = "block";
    document.querySelector('#txtCpf').focus();
}

const InserirCNPJ = () => {
    addId.style.display = "none";
    cnpjId.style.display = "block";
    document.querySelector('#txtCnpj').focus();
}

const OcultarModals = () => {
    addId.style.display = "flex";
    cpfId.style.display = "none";
    cnpjId.style.display = "none";
    document.querySelector('#txtCpf').value = "";
    document.querySelector('#txtCnpj').value = "";
}