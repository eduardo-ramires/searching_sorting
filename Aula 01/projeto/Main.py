import sys
from pathlib import Path

sys.path.insert(0, str(Path(__file__).resolve().parent.parent))

from projeto.controller import ListaController


def main():
  ListaController.executar_processamento()

if __name__ == "__main__":
  main()