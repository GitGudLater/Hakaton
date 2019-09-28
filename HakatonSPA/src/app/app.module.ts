import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SityRoutesComponent } from './sity-routes/sity-routes.component';
import { SityRoutesService } from './sity-routes/Services/sity-routes.service';
import { AccountService } from './services/account.service';
import { AccountComponent } from './account/account.component';
import { MapComponent } from './map/map.component';

@NgModule({
  declarations: [
    AppComponent,
    SityRoutesComponent,
    AccountComponent,
    MapComponent,
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
