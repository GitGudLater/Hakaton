import { Component, OnInit } from '@angular/core';

declare var ymaps:any;

@Component({
  selector: 'app-map',
  templateUrl: './map.component.html',
  styleUrls: ['./map.component.sass']
})
export class MapComponent implements OnInit {

  constructor() { }

  public map :any;

  ngOnInit() {
    ymaps.ready().then(() => {
      this.map = new ymaps.Map('map', {
        center: [53.8981, 30.3325],
        zoom: 13
      });
    });
  }

  updatePath(startPoint: string, endPoint: string){
    ymaps.multiRouter.MultiRoute({
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
  }

}
