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

}
