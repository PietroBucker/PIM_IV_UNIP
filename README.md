# PIM_IV

Este é um projeto desenvolvido em C# para gerenciamento de resíduos industriais, com funcionalidades para cadastro de empresas, atualização de resíduos e geração de relatórios.

# OBS
## usuairo: usuario1
## senha: senha123

## Funcionalidades

- **Cadastro de Empresas**: Registre informações de empresas como nome do responsável, telefone, endereço, e outros dados importantes.
- **Atualização de Resíduos**: Atualize os dados de resíduos tratados pela empresa.
- **Relatórios**:
  - Relatórios individualizados:
    - Total de insumos tratados semestralmente.
    - Total de gastos mensais.
  - Relatórios globais:
    - Regiões com maior volume de resíduos tratados.
    - Indústrias com menor produção no último semestre.
    - Aporte financeiro semestral.
- **Exportação de Dados**: As informações são salvas e podem ser baixadas em formato CSV.

## Requisitos

- .NET 6.0 ou superior (apenas para rodar o projeto no Linux ou gerar novas publicações).
- Arquivo executável gerado:
  - Para **Linux**: `PIM_IV`.
  - Para **Windows**: `PIM_IV.exe`.

## Instalação

1. **Linux**:
   - Baixe o arquivo `PIM_IV.tar.gz` e extraia:
     ```bash
     tar -xzvf PIM_IV.tar.gz
     ```
   - Execute o arquivo:
     ```bash
     ./PIM_IV
     ```

2. **Windows**:
   - Baixe o arquivo `PIM_IV.zip` e extraia.
   - Dê um duplo clique em `PIM_IV.exe` ou execute via terminal:
     ```bash
     PIM_IV.exe
     ```

## Uso

- **Menu Principal**:
  - **1** - Cadastro de Empresa.
  - **2** - Atualizar Resíduos.
  - **3** - Gerar Relatórios.
  - **4** - Baixar Arquivo CSV.
  - **0** - Sair.

Os dados são automaticamente salvos em um arquivo CSV na pasta `data` do projeto.

## Autor

- **Nome**: Pietro
- **Contato**: *Insira aqui seu email ou outra forma de contato*.
