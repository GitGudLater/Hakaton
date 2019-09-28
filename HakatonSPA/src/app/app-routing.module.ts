import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SityRoutesComponent } from './sity-routes/sity-routes.component';
import { SityRoutesService } from './sity-routes/Services/sity-routes.service';
import { AccountComponent } from 'src/app/account/account.component';

const routes: Routes = [
  { path: 'app-sity-routes', component: SityRoutesComponent },
  { path: 'app-account', component: AccountComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes),],
  exports: [RouterModule],
})
export class AppRoutingModule { }
