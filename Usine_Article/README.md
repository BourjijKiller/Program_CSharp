# CRÉATION D'UNE FABRIQUE D'ARTICLE DE SPORT

---------------------------------------------------------

## DESCRIPTION

Réalisation d'une application de type _WindowsForm_ en langage C# sous visual studio permettant de gérer un logiciel de gestion d'articles de sport, le but étant le même que dans le programme de répertoire de contact (disponible sur ce [lien](https://github.com/BourjijKiller/Program_CSharp/tree/master/R%C3%A9pertoire_Contact)) pour apprendre les bases du langage C# ainsi que l'utilisation de visual studio.

Création d'un logiciel gérant des articles de sport. Dans ce logiciel, tout est stocké dans une liste d’articles appelée **usine à article**. C’est l’usine qui est en charge de la gestion et de la création de n’importe quels articles. Les articles possèdent un **identifiant**, un **nom commun**, une **forme**, une **matière** ainsi qu'une **action**.

En ce qui concerne la <span style="color: #FF2D40; text-decoration: underline;"> matière </span>, elle possède un **nom** et une **densité**. L'application développée permet à l'utilisateur de pouvoir créer ses propres matières via un formulaire.

Les articles sont de 3 types :
* <span style="color: #0e5ed1; text-decoration: underline;"> Ballon de foot </span>
* <span style="color: #0e5ed1; text-decoration: underline;"> Club de golf </span>
* <span style="color: #0e5ed1; text-decoration: underline;"> Planche à voile </span>

L'utilisateur peut donc ajouter autant d'article qu'il le souhaite, en précisant le type d'article.

---------------------------------------------------------

## OPÉRATIONS POSSIBLES

* Affichage de tout les articles enregistrés par l'utilisateur dans une liste. De plus, si l'utilisateur double-clic sur l'un des article présent dans la liste, il peut visualiser les informations complètes insérées dans une boite de dialogue.

![](https://image.noelshack.com/fichiers/2018/03/6/1516487360-capture.png)
![](https://image.noelshack.com/fichiers/2018/03/6/1516487406-capture2.png)

* Ajout de matières personnalisées
* Ajout d'articles de sport <p> &nbsp; </p> <span style="color: #eb1313; font-weight: bold; font-style: italic;"> [EN DÉVELOPPEMENT] </span>
* Suppression d'articles sélectionnés depuis le panier <p> &nbsp; </p> <span style="color: #eb1313; font-weight: bold; font-style: italic;"> [EN DÉVELOPPEMENT] </span>

L'application contient donc
1. Un formulaire dit **d'entrée** permettant l'affichage et la suppression d'articles
2. Un formulaire **d'ajout** permettant l'ajout d'articles dans l'usine

**La gestion en mémoire se fait par une liste d'articles [BindingList](https://msdn.microsoft.com/fr-fr/library/ms132679(v=vs.110).aspx)**

--------------------------------------

## NOTIONS UTILISÉES

* _Héritage_
* _Concepts objet_
* _Interface .NET_
* _Interface ICloneable_

--------------------------------------

## LANCEMENT

Exécuter le projet avec l'IDE `Visual Studio`

#### AVANCEMENT --> 65%

_Dernière modification le 20/01/2018, 23:41_