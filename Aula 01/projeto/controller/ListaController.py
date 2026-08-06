import time
from projeto.model.Utilidades import popular_lista

def executar_processamento():
    lista_aleatoria = []
    lista_sequencial = []

    tempo_inicio = time.time_ns()
    popular_lista(lista_aleatoria, 100000, 100, 100000, True)
    tempo_fim = time.time_ns()

    print("Tempo da rotina 1: ", (tempo_fim - tempo_inicio) , "s")  

    tempo_inicio = time.time_ns()
    popular_lista(lista_sequencial, 100000, 1, 100000, False)
    tempo_fim = time.time_ns()


    print("Tempo da rotina 1: ", (tempo_fim - tempo_inicio) , "s")     