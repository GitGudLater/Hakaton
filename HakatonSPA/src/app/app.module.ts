import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { AngularYandexMapsModule } from 'angular8-yandex-maps';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SityRoutesComponent } from './sity-routes/sity-routes.component';
import { SityRoutesService } from './sity-routes/Services/sity-routes.service';
import { MapComponent } from './map/map.component';

@NgModule({
  declarations: [
    AppComponent,
    SityRoutesComponent,
    MapComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    AppRoutingModule,
    AngularYandexMapsModule.forRoot('d3786fc7-5b58-4366-9a10-6410d91bc85f')
  ],
  providers: [SityRoutesService],
  bootstrap: [AppComponent]
})
export class AppModule { }
