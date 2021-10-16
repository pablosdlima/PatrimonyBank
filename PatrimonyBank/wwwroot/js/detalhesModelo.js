const addId = document.querySelector('#addId');
const cpfId = document.querySelector('#cpfId');

const InserirDetalhe = () => {
    addId.style.display = "none";
    cpfId.style.display = "block";
    document.querySelector('#txtCpf').focus();
}

const OcultarModals = () => {
    addId.style.display = "flex";
    cpfId.style.display = "none";
    document.querySelector('#txtCpf').value = "";
}