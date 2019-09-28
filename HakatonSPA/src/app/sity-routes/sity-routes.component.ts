import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Car } from '../Models/car';
import { SityRoutesService } from '../sity-routes/Services/sity-routes.service';

@Component({
  selector: 'app-sity-routes',
  templateUrl: './sity-routes.component.html',
  styleUrls: ['./sity-routes.component.sass']
})
export class SityRoutesComponent implements OnInit {

  public sityRoute:Car;
  public sityRoutes:Car[] = [];

  constructor( private sityRouteService:SityRoutesService) {
   }

  ngOnInit() {
    //this.getRoutes();
    this.addTestRoute();
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
  }
}
