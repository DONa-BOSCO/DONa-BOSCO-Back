# DONa-Bosco-Back# 

 <h2 align="center"> :kimono: Welcome to DONa BOSCOs</h2>
 <div align="center"><img src="https://user-images.githubusercontent.com/117834362/226922234-ce15524f-26c2-4ff8-ac0f-c2053b1015e2.png"></div>

 
<h2 align="center"> :computer: How to install the project (Back) </h2>
<p align="center> This section demonstrates how to set up your own local database and how to connect it to the API we developed specifically for Sakura-Kimonos-Front project to use. 
It must be noted that, even though the Sakura-Kimonos-Front project may be run using json-server, it is highly recommended to set it up using Sakura-Kimonos-Back project.   </h3> 
<p> </p> 

<h3 align="center"> Recommended installation steps </h3> 

1. Clone repository (preferably next to Sakura-Kimonos-Front repository, we go hand in hand)  </p> 

2. Create your own local database in Microsoft SQL Server Management Studio </p> 

3. Connect your new database to Sakura-Kimonos-Back project accessing _appsettings.json_ file </p> 
4. Run *add-migration _name_ -Project Data* 
                  
5. Run *update-database*                 

6. Gheck the connection is active in the Server Explorer </p> 

7. All set! Build Sakura-Kimonos -Back solution and run _npm run dev_ command in Sakura-Kimonos-Front project </p> 

> While connecting the project to your database, note that your *Data source=...* and *initial catalog=...* corresponds to the name of your computer and the name of your database respectively.  

<h2 align="center"> :mag: In depth </h2> 

<p align="center"> Here you can find more information about the built-in entities and methods in 1.0 version of Sakura-Kimonos-Back project. </p> 


| Entities    | Methods         |
| ------------|:---------------:| 
| User        | GetAll          | 
| Product     | Add/Insert/Post |   
| File        | Update/Patch    |   
| UserRol     | Deactivate      |    
| Orders      | Delete          |   
|             | GetById         | 
|             | GetByCriteria   |

> Note that not every entity has all built-in methods in this 1.0 version, but may be implemented in future versions according to the clients' needs. 

<h2 align="center">  🧪Next Steps:</h2>

<p align="center"> - Implement security architecture with Admin/User validation and permissions </p>
<p align="center"> - Development of new methods and entities in accord to new functionalities </p> 
<p align="center"> - Improve File management system </p>  

<h2> 👩‍ 💻Group members:</h2>

|<img src="https://user-images.githubusercontent.com/117834362/226867726-d41a6307-9121-48bf-9083-acbb2da7db5e.jpg" width=115><p>Scrum Master</p><h5><a href="https://github.com/Rocio-Leiva">Rocío Leiva</a></h5><h5><a href="https://www.linkedin.com/in/rocio-leiva-pecho/">LinkedIn</a></h5>|<img src="https://user-images.githubusercontent.com/117834362/226889415-9cee7e56-4bf8-439b-9221-fbdc7332b48a.jpg" width=115><p>Product Owner</p><h5><a href="https://github.com/EvaAramburu">Eva Aramburu</a></h5><h5><a href="https://www.linkedIn.com/in/eva-aramburu19950913/">LinkedIn</a></h5>|<img src="https://user-images.githubusercontent.com/117834362/226875930-748fc1d7-13ba-4be0-b59a-1a5ba8892dd2.png" width=115><p>Developer</p><h5><a href="https://github.com/Ma-shi22">María Carvalho</a></h5><h5><a href="https://www.linkedin.com/in/mariashirleicarvalho/">LinkedIn</a></h5>|<img src="https://user-images.githubusercontent.com/117834362/226876284-d3489d97-f910-4cb9-9470-af3f6fa31da2.png" width=115><p>Developer</p><h5><a href="https://github.com/Diancris">Diana Romero</a></h5><h5><a href="">LinkedIn</a></h5>|<img src="https://user-images.githubusercontent.com/117834362/226876297-6c7b09d6-c2fe-4a4e-9406-324bd8aca214.jpg" width=115><p>Developer</p><h5><a href="https://github.com/VeronicaAnais">Verónica Gallardo</a></h5><h5><a href="https://www.linkedin.com/in/ver%C3%B3nica-gallardo-pedemonte-b537314b/">LinkedIn</a></h5>|
| :---: | :---: | :---: | :---: | :---: |

*Developed with :sparkling_heart: by Sakura-Kimonos Team*
