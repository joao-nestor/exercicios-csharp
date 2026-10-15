# RPG Simples com POO em C#

## Sobre o projeto

Este projeto consiste em um RPG simples desenvolvido em C# utilizando o terminal. Dois personagens participam de um combate, no qual os ataques acontecem aleatoriamente até que um deles perca todos os pontos de vida.

O projeto foi desenvolvido como exercício prático durante meus estudos de Programação Orientada a Objetos (POO).

## Funcionalidades

- Definição dos nomes do jogador e do inimigo.
- Sistema de pontos de vida.
- Dano de ataque aleatório.
- Escolha aleatória de qual personagem ataca em cada rodada.
- Exibição do dano recebido e dos pontos de vida.
- Encerramento automático do combate quando um personagem perde.

## Conceitos praticados

- Classes e objetos.
- Atributos e métodos.
- Métodos com retorno de valores.
- Instanciação de objetos.
- Estruturas condicionais (`if` e `else`).
- Laço de repetição (`while`).
- Tipo `bool`.
- Geração de números aleatórios com `Random.Shared`.
- Interpolação de strings.

## Melhorias futuras

- [ ] Calcular o dano apenas para o personagem que for atacar naquela rodada, evitando gerar valores que não serão utilizados.
- [ ] Melhorar o gerenciamento dos pontos de vida, evitando precisar definir manualmente a vida como zero quando um personagem perde.

## Tecnologias utilizadas

- C#
- .NET

## Como executar

1. Clone este repositório.
2. Abra a pasta do projeto no terminal.
3. Execute o comando:

```bash
dotnet run
```

## Objetivo

Praticar os fundamentos de C# e aplicar os primeiros conceitos de POO na criação de um jogo simples, servindo como base para projetos futuros.
