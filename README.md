# DONa-Bosco-Back# 

 <h2 align="center"> :kimono: Welcome to DONa BOSCOs</h2>
 <div align="center"><img src="https://user-images.githubusercontent.com/117834362/232772720-66bf2d7e-8e03-41be-9ee4-bc8930a5b2e6.png"></div>

 
<h2 align="center"> :computer: How to install the project (Back) </h2>
<p align="center> This section demonstrates how to set up your own local database and how to connect it to the API we developed specifically for DONa-Bosco-Front project to use. 
It must be noted that, even though the DONa-Bosco-Front project may be run using json-server, it is highly recommended to set it up using DONa-Bosco-Back project.   </h3> 
<p> </p> 

<h3 align="center"> Recommended installation steps </h3> 

1. Clone repository (preferably next to DONa-Bosco-Front repository, we go hand in hand)  </p> 

2. Create your own local database in Microsoft SQL Server Management Studio </p> 

3. Connect your new database to DONa-Bosco-Back project accessing _appsettings.json_ file </p> 
4. Run *add-migration _name_ -Project Data* 
                  
5. Run *update-database*                 

6. Gheck the connection is active in the Server Explorer </p> 

7. All set! Build DONa-Bosco-Back solution and run _npm run dev_ command in DONa-Bosco-Front project </p> 

> While connecting the project to your database, note that your *Data source=...* and *initial catalog=...* corresponds to the name of your computer and the name of your database respectively.  

<h2 align="center"> :mag: In depth </h2> 

<p align="center"> Here you can find more information about the built-in entities and methods in 1.0 version of DONa-Bosco-Back project. </p> 


| Entities    | Methods         |
| ------------|:---------------:| 
| User        | GetAll          | 
| Product     | Add/Insert/Post |   
| File        | Update/Patch    |   
| UserRol     | Deactivate      |    
|             | GetById         | 
|             | GetByCriteria   |

> Note that not every entity has all built-in methods in this 1.0 version, but may be implemented in future versions according to the clients' needs. 

<h2 align="center">  🧪Next Steps:</h2>

<p align="center"> - Text </p>
<p align="center"> - Text </p> 
<p align="center"> - Text </p>  

<h2> 👩‍ 💻Group members:</h2>

|<img src="https://user-images.githubusercontent.com/117834362/232775703-7d23d054-84ad-42a5-a5f8-1b4abd438bd2.png" width=115><p>Scrum Master</p><h5><a href="https://github.com/CLAUDETTEGONZALEZ">Claudette Gonzalez</a></h5><h5><a href="https://www.linkedin.com/in/claudette-gonzalez-4651aa266/">LinkedIn</a></h5>|<img src="https://user-images.githubusercontent.com/117834362/232777941-ed5e4902-4d5b-4ef1-843f-3f1de5f58809.png" width=115><p>Product Owner</p><h5><a href="https://github.com/AldaraMG">Aldara Martínez</a></h5><h5><a href="https://www.linkedin.com/in/aldara-mart%C3%ADnez-g%C3%A1lvez-a937a2127/">LinkedIn</a></h5>|<img src="https://user-images.githubusercontent.com/117834362/232779747-92d5c615-5084-4ee6-a28b-b7e84471c613.png" width=115><p>Developer</p><h5><a href="https://github.com/MagdalenaRB">Magdalena Reig</a></h5><h5><a href="https://www.linkedin.com/in/magdalena-reig-baratech-6607b8202/">LinkedIn</a></h5>|<img src="https://user-images.githubusercontent.com/117834362/226876297-6c7b09d6-c2fe-4a4e-9406-324bd8aca214.jpg" width=115><p>Developer</p><h5><a href="https://github.com/VeronicaAnais">Verónica Gallardo</a></h5><h5><a href="https://www.linkedin.com/in/ver%C3%B3nica-gallardo-pedemonte-b537314b/">LinkedIn</a></h5>|<img src="https://user-images.githubusercontent.com/117834362/226867726-d41a6307-9121-48bf-9083-acbb2da7db5e.jpg" width=115><p>Developer</p><h5><a href="https://github.com/Rocio-Leiva">Rocío Leiva</a></h5><h5><a href="https://www.linkedin.com/in/rocio-leiva-pecho/">LinkedIn</a></h5>|<img src="https://user-images.githubusercontent.com/117834362/232781205-7cf66bfe-8faf-429f-a3a9-11082535c1a6.png" width=115><p>Developer</p><h5><a href="https://github.com/miriamremesal">Miriam García</a></h5><h5><a href="https://www.linkedin.com/in/miriam-garc%C3%ADa-remesal-4560181a1/">LinkedIn</a></h5>
| :---: | :---: | :---: | :---: | :---: | :---: |

*Developed with :sparkling_heart: by DONa Bosco Team*
