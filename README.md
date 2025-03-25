# MediatekDocuments
Cette application permet de gérer les documents (livres, DVD, revues) d'une médiathèque, les commandes, ainsi que les exemplaires associés à chaque document. Elle a été codée en C# sous Visual Studio 2019. C'est une application de bureau, prévue pour être installée sur plusieurs postes, accédant à la même base de données. 
L'application exploite une API REST pour accéder à la BDD MySQL. Des explications sont données plus loin, ainsi que le mode opératoire pour installer et utiliser l'application en local. <br><br>

Cette application a été développée dans le cadre du 2ème atelier de professionnalisation de 2ème année de BTS SIO. Le but de cet atelier est de faire évoluer une application de bureau existante, en y ajoutant des fonctionnalités. Le dépôt d'origine est accessible au lien suivant : https://github.com/CNED-SLAM/MediaTekDocuments. Il contient dans le readme, la présentation de l'application d'origine. <br><br>

Dans le readme de ce dépôt seront uniquement présentées les fonctionnalités ajoutées. <br>

## Présentation
Avant la réalisation de cet atelier, l'application était partiellement codée, et contenait les fonctionnalités suivantes : <br>
- Recherches et affichage d'informations sur les documents de la médiathèques (livres, DVD, revues)<br>
- Réception de nouveaux numéros de revues <br><br>

Lors de cet atelier, les fonctionnalités suivantes ont été ajoutées :<br>
- Gestion des documents (livres, DVD, revues) : ajout, modification (excepté l'identifiant), et suppression (uniquement s'il ny a pas de commandes et d'exemplaires). <br>
- Gestion des commandes : commandes de livres et DVD (commander un ou plusieurs exemplaires, gérer le stade de la commande : "en cours", "relancée", "réglée", afficher la liste des commandes et leur stade, générer les exemplaires lors de la livraison), commandes de revues (correspond à un abonnement ou un renouvellement d'abonnement) <br>
- Gestion du suivi des états des documents physiques, donc des exemplaires ("neuf", "usagé", "détérioré", "inutilisable").<br>
- Limitation des accès : l'administrateur et le personnel du service administratif ont accès à toutes les fonctionnalités, les employés du service "prêts" n'ont accès qu'aux fonctionalités de consultation des documents, les employés du service "culture" (organisation des évènements) ne se ont pas censés manipuler cette application <br><br>

L'application ne comporte qu'une seule fenêtre, divisée en plusieurs onglets. <br>

## Les différents onglets
### Onglet 1 : Livres
Cet onglet présente la liste des livres avec les informations détaillées, et les exemplaires associés. Les fonctionnalités existantes sont détaillées dans le readme du dépôt d'origine.<br>
Les fonctionnalités ajoutées au niveau du code sont les suivantes :<br>

#### Ajout d'un livre
Il est possible, en vidant automatiquement les informations détaillées sur un document, d'ajouter un nouveau livre. On peut ainsi renseigner l'ensemble des informations suivantes : numéro de document, code ISBN, titre, auteur, collection, genre, public, rayon, chemin de l'image. Un combo automatiquement créé et rempli, permet la sélection du genre, public et rayon pour un nouveau livre. <br>
A la création d'un nouveau livre : <br>
- Si un autre document existe déjà avec le même numéro : une fenêtre apparaît indiquant l'erreur et son motif, et l'ajout est annulé. <br>
- Sinon : le nouveau livre est ajouté dans la liste, après confirmation par un message d'alerte. <br><br>

Lors de la création d'un nouveau livre, on peut soit "Valider", soit "Annuler" l'ajout, ce qui renvoit aux actions correspondantes. 

#### Modification d'un livre
Il est possible, après avoir sélectionné un livre dans la liste, et cliqué sur le bouton "Modifier", de modifier un livre existant. Pour cela, le formulaire est automatiquement adapté, pour permettre la modification de toutes les informations disponibles sur le document. Les zones de textes et combo sont donc tous remplis avec les informations existantes sur le livre donné. <br>
A la modification d'un nouveau livre : <br>
- Si la modification porte sur le numéro, et que le nouveau numéro renseigné est déjà associé à un autre document : une fenêtre apparaît indiquant l'erreur et son motif, et l'ajout est annulé<br>
- Sinon : la modification du livre apparaît dans la liste, après confirmation par un message d'alerte. <br><br>

Lors de la modification d'un livre existant, on peut soit "Valider", soit "Annuler" la modification, ce qui renvoit aux actions correspondantes.

#### Suppression d'un livre
Il est possible, après avoir sélectionné un livre dans la liste, de le supprimer, en cliquant sur le bouton "Supprimer". Cette action amène l'utilisateur à confirmer ou refuser la suppression, grâce à une fenêtre de confirmation. <br><br>

La suppression est possible uniquement si le document que l'on souhaite supprimer n'est rattaché à aucun document, ou aucune commande. Dans ce cas, le livre est bien supprimé de la liste, sinon une erreur est affichée, et la suppression n'a pas lieu. 

#### Modification de l'état d'un exemplaire
Au-dessous de la zone contenant les informations détaillées d'un livre, on trouve deux zones : <br>
- Un tableau contenant la liste des exemplaires rattachés au livre sélectionné plus haut <br>
- Une zone permettant la modification de l'état de l'exemplaire, ou la suppression de l'exemplaire. <br><br>

Il est donc possible, après avoir sélectionné un exemplaire de livre dans la liste, de modifier son état parmi les 4 existants : "neuf", "usagé", "détérioré", "inutilisable", grâce à un combo rempli par défaut avec les états disponibles. Une fois le nouvel état sélectionné dans la liste, en cliquant sur le bouton "Modifier l'état de l'exemplaire", la modification apparaît dans la liste en bas à gauche de la fenêtre. 

#### Suppression d'un exemplaire
Il est possible, après avoir sélectionné un exemplaire de livre dans la liste, de le supprimer, grâce au bouton "Supprimer l'exemplaire". En cliquant sur ce bouton, une nouvelle fenêtre pop-up s'ouvre, demandant confirmation à l'utilisateur s'il souhaite bien supprimer l'exemplaire ou non. Une fois que l'utilisateur confirme, l'exemplaire est bien supprimé de la liste. <br>
<img width="385" alt="image" src="https://github.com/user-attachments/assets/02a68974-c7fb-4446-ba1e-682d98722981" />


### Onglet 2 : Dvd
Cet onglet présente la liste des DVD avec les informations détaillées et les exemplaires associés. Les fonctionnalités existantes sont détaillées dans le readme du dépôt d'origine. <br><br>

Les fonctionnalités ajoutées au niveau de cet onglet sont les mêmes que pour l'onglet de gestion des livres. Leur fonctionnement est donc identique à l'onglet des livres. <br>
- Ajout d'un DVD <br>
- Modification d'un DVD <br>
- Suppression d'un DVD <br>
- Modification de l'état de l'exemplaire d'un DVD <br>
- Suppression d'un exemplaire de DVD <br><br>

La seule différence réside dans certaines informations détaillées, spécifiques aux DVD : durée (à la place de ISBN), réalisateur (à la place de l'auteur), synopsis (à la place de collection). <br>

<img width="385" alt="image" src="https://github.com/user-attachments/assets/113017d4-21bb-4b0f-b87c-7b82b3674195" />

### Onglet 3 : Revues
Cet onglet présente la liste des revues avec les informations détaillées. Les fonctionnalités existantes sont détaillées dans le readme du dépôt d'origine. <br><br>

Les fonctionnalités ajoutées au niveau de cet onglet sont en partie les mêmes que pour l'onglet de gestion des livres : <br>
- Ajout d'une revue <br>
- Modification d'une revue <br>
- Suppression d'une revue <br>
La gestion des exemplaires de revue sera géré dans l'onglet 4 : Parution des revues. <br><br>

La seule différence réside dans certaines informations détaillées, spécifiques aux revues : périodicité (à la place de l'auteur), délai mise à dispo (à la place de collection). <br>

<img width="385" alt="image" src="https://github.com/user-attachments/assets/277d6526-cd79-4683-8210-a7ddb2de3426" />

### Onglet 4 : Parutions des revues 
Cet onglet permet d'enregistrer la réception de nouvelles parutions d'une revue. Les fonctionnalités existantes sont détaillées dans le readme du dépôt d'origine. <br><br>

Au-dessous de la partie "Nouvelle parution réceptionnée pour cette revue", est ajoutée la zone "Informations sur l'exemplaire", permettant d'intégrer les deux fonctionnalités, identiques à l'onglet de gestion des livres : <br>
- Modification de l'état d'un exemplaire <br>
- Suppression d'un exemplaire<br><br>

La seule différence réside dans l'affichage de la zone et la présentation de la fenêtre. <br>

<img width="385" alt="image" src="https://github.com/user-attachments/assets/b72af7aa-ff5b-4fc8-9e1a-930a88b7c5ac" />

### Onglet 5 : Commandes de livres
Cet onglet permet de gérer les commandes de livres. Il se décompose en plusieurs parties, correspondants à des fonctionnalités. 

#### Sélection du livre
Cette partie permet de sélectionner dans une liste déroulante, un livre existant (grâce à son numéro suivi de son titre). Si le bouton "Rechercher" est utilisé, alors toutes les zones seront remplies avec les informations correspondantes à ce livre. 

#### Affichage des informations détaillées
Cette partie est identique à celle présente dans l'onglet de gestion des livres, elle présente les informations détaillées du livre recherché (numéro de document, code ISBN, titre, auteur(e), collection, genre, public, rayon, chemin de l'image) ainsi que l'image.  

#### Affichage des commandes 
Si le livre recherché est associé à une ou plusieurs commande(s), la liste est remplie avec toutes les commandes correspondantes. Ces informations portent sur : la date de la commande, le nombre d'exemplaires, montant, le suivi. <br>
Le fait de cliquer sur le titre d'une des colonnes de la liste des commandes de livres, permet de trier la liste par rapport à la colonne choisie. 

#### Ajout d'une commande 
Il est possible, en cliquant sur le bouton "Ajouter une commande", de commander un ou plusieurs exemplaires du livre choisi. En cliquant sur le bouton les informations détaillées sur la commandes sont vidées, et sont rendues accessibles, pour permettre de renseigner de nouvelles informations : numéro de commande, montant, nombre d'exemplaire(s) et date de la commande. <br>
A la création de la commande : <br>
- Si une autre commande existe déjà avec le même numéro : une fenêtre apparaît indiquant l'erreur et son motif, et l'ajout est annulé <br>
- Sinon : la nouvelle commande est ajoutée dans la liste, après confirmation par un message d'alerte. <br><br>

Lors de la création d'une commande, on peut soit "Valider", soit "Annuler" l'ajout, ce qui renvoit aux actions correspondantes. 

#### Suppression d'une commande
Il est possible, après avoir sélectionné une commande dans la liste, de la supprimer, en cliquant sur le bouton "Supprimer la commande". <br>

La suppression est possible uniquement si la commande que l'on souhaite supprimer n'a pas encore été livrée. Dans ce cas la commande est bien supprimée, sinon, le bouton "Supprimer la commande" n'est pas accessible, et la suppression est impossible. 

#### Modification du stade de la commande
Il est possible, après avoir sélectionné une commande dans la liste, de modifier son suivi (sauf si l'étape de suivi est déjà "livrée") grâce à un combo pré-rempli. Il est alors possible de gérer le suivi de la façon suivante : <br>
- Une commande "en cours" peut passer aux stades "livrée" et "relancée"<br>
- Une commande "livrée" peut passer au stade "réglée" <br>
- Une commande "relancée" peut passer aux stades "en cours" ou "livrée". <br>
- Une commande "réglée" ne peut pas revenir à un autre stade. <br><br>

Si une commande passe au stade "livrée", alors le nombre d'exemplaire(s) correspondant à la commande est généré dans la base de données. <br>

Lors de la modification du stade de la commande, on peut soit "Modifier l'étape de suivi", soit "Annuler la modification", grâce aux boutons correspondants. <br>

<img width="385" alt="image" src="https://github.com/user-attachments/assets/2ce937b3-4e67-4bbc-8e2b-5a5750b2c103" />

### Onglet 6 : Commandes de dvd
Cet onglet permet de gérer les commandes de dvd. Il se décompose en plusieurs parties, correspondants à des fonctionnalités. <br><br>

Le fonctionnement de cet onglet est identique à celui de la gestion des commandes de livres : <br>
- Sélection du dvd<br>
- Affichage des informations détaillées du dvd<br>
- Affichage des commandes de dvd<br>
- Ajout d'une commande de dvd<br>
- Suppression d'une commande de dvd<br>
- Modification du stade de la commande <br><br>

La seule différence réside dans les informations détaillées, qui sont ici spécifiques aux DVD. <br>

<img width="385" alt="image" src="https://github.com/user-attachments/assets/5ac1bf4e-355e-4d5a-99ad-839a0554c10d" />

### Onglet 7 : Commandes de revues
Cet onglet permet de gérer les commandes de revues (correspondant cette fois-ci à un abonnement ou un renouvellement d'abonnement). Il se décompose en plusieurs parties, correspondants à des fonctionnalités.<br><br>

Le fonctionnement de certaines fonctionnalités est identique à celui de la gestion des commandes de livres : <br>
- Sélection de la revue <br>
- Affichage des informations détaillées de la revue <br>
- Affichage des commandes de revues <br>
- Ajout d'une commande de revue <br>
- Suppression d'une commande de revue <br><br>

Les seules différences résident dans : <br>
- Les informations détaillées, qui sont ici spécifiques aux revues <br>
- Les informations sur une commande : date de fin d'abonnement (au lieu du nombre d'exemplaires), et il n'y a ici pas de gestion du suivi de la commande. <br><br>

Cet onglet permet aussi la création d'une fenêtre d'alerte au lancement de l'application, rappelant à l'utilisateur les abonnements qui arrivent à expiration dans moins de 30 jours. <br>

<img width="385" alt="image" src="https://github.com/user-attachments/assets/fc71f8fa-85d9-4676-9a0b-ed1c574ba68a" />

 
## L'API REST
L'accès à la BDD se fait à travers une API REST protégée par une authentification basique.<br>
Le code de l'API se trouve ici :<br>
https://github.com/fanny1304/rest_mediatekdocuments <br>
L'API en ligne est accessible au lien suivant : <br>
https://aquamarine-ibex-925456.hostingersite.com/rest_mediatekdocuments/<br><br>

Toutes les explications concernant l'utilisation de l'API (local ou en ligne), se trouvent dans le readme du dépôt de l'API. 

## Mode opératoire pour installer et utiliser l'application
Ce mode opératoire permet d'installer l'application pour pouvoir travailler dessus.<br>
- Vérifier que Git, Wampserver (ou équivalent) et Visual Studio 2019 entreprise (avec l'extension newtonsoft.json) sont installés sur l'ordinateur<br>
- Télécharger le code et le dézipper, puis renommer le dossier en "mediatekdocuments"<br>
- Récupérer et installer l'API REST nécessaire, au lien suivant : https://github.com/fanny1304/rest_mediatekdocuments (voir le mode opératoire dans le readme du dépôt) <br>
- Dans phpMyAdmin, se connecter à MySQL en root sans mot de passe et créer la BDD "mediatek86"
- Récupérer le fichier "mediatek86.sql" (en racine du dépôt de l'API), et l'utiliser pour créer et remplir la BDD. 

