import random


def popular_lista(lista: list, quantidade_numeros: int, inicio: int, fim: int, aleatorio: bool):
  if aleatorio:
    for _ in range(quantidade_numeros):
      lista.append(random.randrange(inicio, fim))
  else:
    for i in range(quantidade_numeros):
      lista.append(inicio + int(i))
