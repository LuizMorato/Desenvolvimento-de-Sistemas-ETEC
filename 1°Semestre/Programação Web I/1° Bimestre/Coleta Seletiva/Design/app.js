const toggleButton = document.getElementById('toggle-buttons')
const naviList = document.getElementById('nav-list')

        toggleButton.addEventListener('click', () => {
            naviList.classList.toggle('active');
        })

    function amarelo() {
        document.getElementById("lixoAmarelo").innerHTML = "Lata de lixo amarela - metal. Ela deve ser o destino das latinhas de cerveja e refrigerante, além dos objetos feitos de ferro, alumínio e aço."
    }
    function verde() {
        document.getElementById("lixoVerde").innerHTML = "É muito importante destacar os materiais mais perigosos e cortantes em uma lixeira específica, pois assim o lixeiro saberá que deve tomar o cuidado necessário na hora da coleta. Nesse caso, vidros devem ser descartados nas lixeiras de cor verde."
    }
    function vermelho() {
        document.getElementById("lixoVermelho").innerHTML = "Garrafas pet e outros materiais plásticos devem ser descartados na lixeira de cor vermelha."
    }
    function azul() {
        document.getElementById("lixoAzul").innerHTML = "As lixeiras de cores azuis, servem para a coleta de papéis. Nela devem ser descartadas todos os lixos que envolvam esse material e também o papelão. "
    }
    function cinza() {
        document.getElementById("lixoCinza").innerHTML = "Todos os resíduos não recicláveis, como restos de alimento, devem ser despejados nas lixeiras de cor cinza."
    }