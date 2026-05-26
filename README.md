# Sunny Runner - EndlessRunner 

## Sobre o Projeto

Sunny Runner é um jogo 2D de corrida infinita desenvolvido em Unity como projeto prático durante as aulas do programa **RenovaTech**, um programa de capacitação em tecnologia e desenvolvimento de jogos.

## Tecnologias Utilizadas

- **Unity** (com Universal Render Pipeline - URP)
- **C#** como linguagem de programação
- **TextMeshPro** para renderização de textos na UI
- **Unity Input System** para gerenciamento de entradas do jogador
- **Unity Tilemaps** para construção do cenário
- **Unity Physics 2D** para colisões e física
- **PlayerPrefs** para persistência de dados (pontuação)

## Conteúdo Aprendido

### Fundamentos de Game Development

- Estrutura de cenas no Unity e gerenciamento com `SceneManager`
- Ciclo de vida de componentes MonoBehaviour (`Awake`, `Start`, `Update`, `FixedUpdate`)
- Sistema de prefabs e instanciação dinâmica de objetos

### Programação em C#

- Orientação a objetos aplicada a jogos (classes, herança, serialização)
- Corrotinas com `IEnumerator` e `StartCoroutine`
- Padrão Singleton para gerenciadores globais (`GameManager`)
- Comunicação entre scripts com referências e `GetComponent`

### Física e Colisões 2D

- Uso de `Rigidbody2D` para física do personagem
- Detecção de colisões com `OnCollisionEnter2D` e `OnTriggerEnter2D`
- Diferença entre colliders físicos e triggers

### Interface do Usuário (UI)

- Criação de Canvas e layouts responsivos com `RectTransform`
- Uso de botões com eventos no Inspector (`UnityEvent`)
- Atualização dinâmica de textos com TextMeshPro

### Audio

- Gerenciamento centralizado de áudio com `AudioSource` e `AudioClip`
- Separação de trilha sonora e efeitos sonoros (Music Source / SFX Source)
- Reprodução de sons pontuais com `PlayOneShot`

### Geração Procedural

- Geração dinâmica de obstáculos com dificuldade progressiva
- Controle de velocidade incremental (`CurrentSpeed`, `SpeedMulti`)
- Sistema de spawn e destruição de objetos fora de tela

### Persistência de Dados

- Salvamento e carregamento de pontuação com `PlayerPrefs`

### Parallax e Efeitos Visuais

- Scrolling de fundo com offset de textura (`SetTextureOffset`)
- Múltiplas camadas de parallax com velocidades diferentes

## Estrutura de Cenas

| Cena | Descrição |
|---|---|
| `MenuInicial` | Tela inicial com botões de começar e sair |
| `MainMenu` | Menu alternativo |
| `CenaPrincipal` | Gameplay principal |
| `GameOver` | Tela de fim de jogo com pontuação e opções de reiniciar |


## Como Jogar


---

Projeto desenvolvido no programa **RenovaTech**.
