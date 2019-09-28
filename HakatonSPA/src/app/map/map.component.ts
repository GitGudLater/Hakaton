import { Component, OnInit } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { MapService } from './services/map.service';
import { Car } from '../Models/car';


declare var ymaps:any;

@Component({
  selector: 'app-map',
  templateUrl: './map.component.html',
  styleUrls: ['./map.component.sass']
})
export class MapComponent implements OnInit {

  public map :any;

  private _car: Car = new Car();

  constructor(private mapService:MapService) { 

  }


  ngOnInit() {
    //this.mapService.items$.subscribe((items)=>this.items=items);
    
    this.mapService.cars$.subscribe((car)=>this._car=car);

    ymaps.ready( ).then(() => {
      this.map = new ymaps.Map('map', {
        center: [53.8981, 30.3325],
        zoom: 13
      });
    });

    this.updatePath(this._car.CoordStart,this._car.CoordFin);
    
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
    ymaps.geoObjects.add(path);
  }

}
