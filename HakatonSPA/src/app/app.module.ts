import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { InjectionToken } from '@angular/core';
export const BASE_URL = new InjectionToken<string>('BASE_URL');


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SityRoutesComponent } from './sity-routes/sity-routes.component';
import { SityRoutesService } from './sity-routes/Services/sity-routes.service';

@NgModule({
  declarations: [
    AppComponent,
    SityRoutesComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    AppRoutingModule
  ],
  providers: [{ provide: BASE_URL , useValue: "http://examlple/api" },SityRoutesService],
  bootstrap: [AppComponent]
})
export class AppModule { }

