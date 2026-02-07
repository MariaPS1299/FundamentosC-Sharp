# Fundamentos de C#
>### Recursos
> - [ZSH](https://ohmyz.sh/)
> - [Visual Studio 2022](https://learn.microsoft.com/es-es/visualstudio/install/install-visual-studio?view=visualstudio)
> - [Visual Studio Code](https://code.visualstudio.com/docs/setup/windows)
> - [Git](https://git-scm.com/install/windows)
> - [Github](https://cli.github.com/)
> - [Conventional Commits](https://www.conventionalcommits.org/en/v1.0.0/)

>### Configuración de un repositorio en GitHub

## 1. Clona el repo que desees:
>Tienes que copiar el URL de alguna de las 3 opciones dependiendo de la configuración del github que tengas en la computadora
><img width="550" height="366" alt="image" src="https://github.com/user-attachments/assets/ce04ba7f-e4a9-4403-84ad-5420aec997d3" />

>Corre este comando desde la terminal de la computadora en la ruta que desees guardar el repositorio.
>🗒️Nota: Puedes crearte una carpeta llamada `repos` y ahi guardar todos los repositorios(proyectos) que vayas haciendo.
```
git clone https://github.com/reish-fdz-jnz/FundamentosC-Sharp.git
```
## 2. Crea un fork del repositorio principal.
>Deja la configuración sugerida y da click en `create`.
>
>Un fork nos permite hacer contribuciones en distintos repositorios donde nosotros no somos los owners.
>
><img width="285" height="152" alt="image" src="https://github.com/user-attachments/assets/4d419717-1651-4b16-a10f-f1f661f48d29" />

## 3. Ve al fork creado y y copia del URL del fork para clonarlo.
><img width="387" height="337" alt="image" src="https://github.com/user-attachments/assets/74bc4bc2-0d6e-4d3c-9738-e8c89635359f" />

#### En la terminal de tu computadora, desde la ruta donde clonaste anteriormente el repositorio, sigue los siguientes pasos:
> Ver los repositorios remotos
```
git remote -v
```

> Agregar el fork como repositorio remoto
```
git remote add --track <nombre-del-repo> <branch-principal> <REPO-URL>
```
### HAPPY CODING! 💻
