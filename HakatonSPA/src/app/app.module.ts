import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AngularYandexMapsModule } from 'angular8-yandex-maps';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MapComponent } from './map/map.component';

@NgModule({
  declarations: [
    AppComponent,
    MapComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    AngularYandexMapsModule.forRoot('d3786fc7-5b58-4366-9a10-6410d91bc85f')
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
