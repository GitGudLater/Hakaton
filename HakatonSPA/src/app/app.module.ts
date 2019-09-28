import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SityRoutesComponent } from './sity-routes/sity-routes.component';
import { SityRoutesService } from './sity-routes/Services/sity-routes.service';
import { MapPartComponent } from './map-part/map-part.component';
import { AccountService } from './services/account.service';
import { AccountComponent } from './account/account.component';

@NgModule({
  declarations: [
    AppComponent,
    SityRoutesComponent,
    MapPartComponent,
    AccountComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    AppRoutingModule
  ],
  providers: [SityRoutesService, AccountService],
  bootstrap: [AppComponent]
})
export class AppModule { }
