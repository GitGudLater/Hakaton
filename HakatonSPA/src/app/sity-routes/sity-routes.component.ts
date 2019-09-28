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

  
  public sityRoutes:Car[];

  constructor( private sityRouteService:SityRoutesService, http: HttpClient, @Inject('BASE_URL') baseUrl: string ) { }

  ngOnInit() {
    this.getRoutes();
  }

  getRoutes(){
    this.sityRouteService.getRoutes().subscribe((data:any) => this.sityRoutes = data);
  }
}
