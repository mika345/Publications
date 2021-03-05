import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PublicationsComponent } from './publications/publications.component';
import { PerTypeComponent } from './per-type/per-type.component';
import { NgxEchartsModule } from 'ngx-echarts';
import { PerTypeService } from './services/per-type.service';
import { PublicationService } from './services/publication.service';

@NgModule({
  declarations: [
    AppComponent,
    PublicationsComponent,
    PerTypeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgxEchartsModule.forRoot({
      echarts: () => import('echarts'),
    }),
  ],
  providers: [PerTypeService, PublicationService],
  bootstrap: [AppComponent]
})
export class AppModule { }
