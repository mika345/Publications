import { Component } from '@angular/core';
import { PerTypeService } from './services/per-type.service';
import { PublicationService } from './services/publication.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers: [PerTypeService, PublicationService]
})
export class AppComponent {
  title = 'CanmetMINING Publications';

  constructor() {

  }


}
