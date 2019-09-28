import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Car } from '../Models/car';
import { SityRoutesService } from '../sity-routes/Services/sity-routes.service';
import { MapService } from '../map/services/map.service';
import { AccountService } from '../services/account.service';
import { User } from '../Models/user';

declare var ymaps:any;


@Component({
  selector: 'app-sity-routes',
  templateUrl: './sity-routes.component.html',
  styleUrls: ['./sity-routes.component.sass']
})
export class SityRoutesComponent implements OnInit {

  public user:User;
  public sityRoute:Car;
  public sityRoutes:Car[] = [];

  public map :any;


  constructor( private accountService:AccountService, private sityRouteService:SityRoutesService,private mapService:MapService) {
   }

  ngOnInit() {
    //this.getRoutes();
    this.addTestRoute();
    this.requestForAUser();
  }

  requestForAUser(){
    this.accountService.getUserInformation().subscribe((data:User)=>this.user=data);
  }

  requestForATrip(_user:User){
  }

  addTestRoute(){
    let test_car:Car = new Car ();
    test_car.Id=0;
    test_car.TBegin = "8:00 am";
    test_car.CoordStart = "Народного-Ополчения 16(а)";
    test_car.CoordFin = "Первомайская 57";
    test_car.EmptySeats = 2;
    test_car.Car = "Wolksvagun Golf";
    test_car.Description = "Hakaton mobilization for sky.NET team";
    let array:Array<string> = ["Saturday"];
    test_car.Days=array;
    this.sityRoutes.push(test_car);
  }

  getRoutes(){
    this.sityRouteService.getRoutes().subscribe((data:any) => this.sityRoutes = data);
  }

  getRouteInformation(route:Car){
    this.sityRoute = route;
    //this.mapService.addPath(route);
    ymaps.ready(this.updatePath(this.sityRoute.CoordStart,this.sityRoute.CoordFin));
    //this.updatePath(this.sityRoute.CoordStart,this.sityRoute.CoordFin);

  }

  updatePath(startPoint: string, endPoint: string){
    var path = new ymaps.multiRouter.MultiRoute({
      referencePoints: [
          startPoint,
          endPoint
      ],
      params: {
          results: 1
      }
    }, {
            boundsAutoApply: true
    });
    var myMap = new ymaps.Map('map',{
        center: [53.8981, 30.3325],
        zoom: 13,
        
    })

    myMap.geoObjects.add(path);
  }

}
