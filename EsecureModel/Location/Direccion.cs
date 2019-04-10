using System;
using System.Collections.Generic;
using System.Text;

namespace EsecureModel.Location
{
    public enum RegionChile
    {
        Región_de_Arica_y_Parinacota,
        _Región_de_Antofagasta,
        _Región_de_Atacama,
        _Región_de_Coquimbo,
        _Región_de_Valparaíso,
        _Región_del_Libertador_General_Bernardo_OHiggins,
        _Región_del_Maule,
        _Región_de_Ñuble,
        _Región_del_Biobío,
        _Región_de_La_Araucanía,
        _Región_de_Los_Ríos,
        _Región_de_Los_Lagos,
        _Región_de_Aisén_del_G_Carlos_Ibáñez_del_Campo,
        _Región_de_Magallanes_y_de_la_Antártica_Chilena,
        _Región_Metropolitana_de_Santiago
    };
    public enum Pais
    {
        Chile,
        Perú,
        Argentina,
        Colombia
    };
    public enum ComunasChile { Santiago, Pudahuel, Est_Central, Quilicura };
    public class Direccion
    {
        public int DireccionID { get; set; }
        public int EmpresaID { get; set; }
        public string ShortName { get; set; }
        public string Calle { get; set; }
        public int Numeracion { get; set; }
        public ComunasChile Comuna { get; set; }
        public RegionChile Region { get; set; }
        public Pais Pais { get; set; }
    }

    /*
     * 
Región
Provincia
Comuna
XV de Arica y Parinacota
Arica
 Arica
 Camarones
Parinacota 
 Putre
 General Lagos     
I de Tarapacá
Iquique
Alto Hospicio
Iquique
Del Tamarugal
Huara
Camiña
Colchane
Pica
Pozo Almonte
II de Antofagasta
Tocopilla
 Tocopilla
 María Elena
El Loa
 Calama
 Ollagüe
 San Pedro de Atacama
Antofagasta
 Antofagasta
 Mejillones
 Sierra Gorda
 Taltal
III de Atacama
Chañaral
 Chañaral
 Diego de Almagro
Copiapó
 Copiapó
 Caldera
 Tierra Amarilla
Huasco
 Vallenar
 Freirina
 Huasco
 Alto del Carmen
IV de Coquimbo
Elqui
 La Serena
 La Higuera
 Coquimbo
 Andacollo
 Vicuña
 Paihuano
Limarí
 Ovalle
 Río Hurtado
 Monte Patria
 Combarbalá
 Punitaqui
Choapa
 Illapel
 Salamanca
 Los Vilos
 Canela
V de Valparaíso
Petorca
 La Ligua
 Petorca
 Cabildo
 Zapallar
 Papudo
Los Andes
 Los Andes
 San Esteban
 Calle Larga
 Rinconada
San Felipe de Aconcagua
 San Felipe
 Putaendo
 Santa María
 Panquehue
 Llaillay
 Catemu
Quillota
 Quillota
 La Cruz
 Calera
 Nogales
 Hijuelas
 Limache
 Olmué
Valparaíso
 Valparaíso
 Viña del Mar
 Quintero
 Puchuncaví
 Quilpué
 Villa Alemana
 Casablanca
 Concón
 Juan Fernández
San Antonio
 San Antonio
 Cartagena
 El Tabo
 El Quisco
 Algarrobo
 Santo Domingo
Isla de Pascua
 Isla de Pascua
VI del Libertador General Bernardo O'Higgins
Cachapoal
 Rancagua
 Graneros
 Mostazal
 Codegua
 Machalí
 Olivar
 Requinoa
 Rengo
 Malloa
 Quinta de Tilcoco
 San Vicente
 Pichidegua
 Peumo
 Coltauco
 Coinco
 Doñihue
 Las Cabras
Colchagua
 San Fernando
 Chimbarongo
 Placilla
 Nancagua
 Chépica
 Santa Cruz
 Lolol
 Pumanque
 Palmilla
 Peralillo
Cardenal Caro
 Pichilemu
 Navidad
 Litueche
 La Estrella
 Marchihue
 Paredones
VII del Maule
Curicó
 Curicó
 Teno
 Romeral
 Molina
 Sagrada Familia
 Hualañé
 Licantén
 Vichuquén
 Rauco
Talca
 Talca
 Pelarco
 Río Claro
 San Clemente
 Maule
 San Rafael
 Empedrado
 Pencahue
 Constitución
 Curepto
Linares
 Linares
 Yerbas Buenas
 Colbún
 Longaví
 Parral
 Retiro
 Villa Alegre
 San Javier
Cauquenes
 Cauquenes
 Pelluhue
 Chanco
VIII del Biobío
Ñuble
 Chillán
 San Carlos
 Ñiquén
 San Fabián
 Coihueco
 Pinto
 San Ignacio
 El Carmen
 Yungay
 Pemuco
 Bulnes
 Quillón
 Ránquil
 Portezuelo
 Coelemu
 Treguaco
 Cobquecura
 Quirihue
 Ninhue
 San Nicolás
 Chillán Viejo
Biobío
 Alto Biobío
 Los Angeles
 Cabrero
 Tucapel
 Antuco
 Quilleco
 Santa Bárbara
 Quilaco
 Mulchén
 Negrete
 Nacimiento
 Laja
 San Rosendo
 Yumbel
Concepción
 Concepción
 Talcahuano
 Penco
 Tomé
 Florida
 Hualpén
 Hualqui
 Santa Juana
 Lota
 Coronel
 San Pedro de la Paz
 Chiguayante
Arauco
 Lebu
 Arauco
 Curanilahue
 Los Alamos
 Cañete
 Contulmo
 Tirua
IX de la Araucanía
Malleco
 Angol
 Renaico
 Collipulli
 Lonquimay
 Curacautín
 Ercilla
 Victoria
 Traiguén
 Lumaco
 Purén
 Los Sauces
Cautín
 Temuco
 Lautaro
 Perquenco
 Vilcún
 Cholchol
 Cunco
 Melipeuco
 Curarrehue
 Pucón
 Villarrica
 Freire
 Pitrufquén
 Gorbea
 Loncoche
 Toltén
 Teodoro Schmidt
 Saavedra
 Carahue
 Nueva Imperial
 Galvarino
 Padre las Casas
XIV de los Ríos
Valdivia
Valdivia
Mariquina
Lanco
Máfil
Corral
Los Lagos
Panguipulli
Paillaco
Ranco
La Unión
Futrono
Río Bueno
Lago Ranco
X de los Lagos
 
Osorno
Osorno
 San Pablo
 Puyehue
 Puerto Octay
 Purranque
 Río Negro
 San Juan de la Costa
Llanquihue
 Puerto Montt
 Puerto Varas
 Cochamó
 Calbuco
 Maullín
 Los Muermos
 Fresia
 Llanquihue
 Frutillar
Chiloé
 Castro
 Ancud
 Quemchi
 Dalcahue
 Curaco de Vélez
 Quinchao
 Puqueldón
 Chonchi
 Queilén
 Quellón
Palena
 Chaitén
 Hualaihué
 Futaleufú
 Palena
XI Aysén del General Carlos Ibáñez del Campo
Coihaique
 Coihaique
 Lago Verde
Aisén
 Aisén
 Cisnes
 Guaitecas
General Carrera
 Chile Chico
 Río Ibánez
  
Capitán Prat
 Cochrane
 O'Higgins
 Tortel
XII de Magallanes y Antártica Chilena
Ultima Esperanza
 Natales
 Torres del Paine
Magallanes
 Punta Arenas
 Río Verde
 Laguna Blanca
 San Gregorio
Tierra del Fuego
 Porvenir
 Primavera
 Timaukel
Antártica Chilena
 Cabo de Hornos
 Antártica
Metropolitana de Santiago
Santiago
 Santiago
 Independencia
 Conchalí
 Huechuraba
 Recoleta
 Providencia
 Vitacura
 Lo Barnechea
 Las Condes
 Ñuñoa
 La Reina
 Macul
 Peñalolén
 La Florida
 San Joaquín
 La Granja
 La Pintana
 San Ramón
 San Miguel
 La Cisterna
 El Bosque
 Pedro Aguirre Cerda
 Lo Espejo
 Estación Central
 Cerrillos
 Maipú
 Quinta Normal
 Lo Prado
 Pudahuel
 Cerro Navia
 Renca
 Quilicura
Chacabuco
 Colina
 Lampa
 Tiltil
Cordillera
 Puente Alto
 San José de Maipo
 Pirque
Maipo
 San Bernardo
 Buin
 Paine
 Calera de Tango
Melipilla
 Melipilla
 María Pinto
 Curacaví
 Alhué
 San Pedro
Talagante
 Talagante
 Peñaflor
 Isla de Maipo
 El Monte
 Padre Hurtado
     */
}
