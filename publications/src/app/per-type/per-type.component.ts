import { Component, OnInit } from '@angular/core';
import { EChartsOption } from 'echarts';
import { SerieModel } from "../model/chart.model";

@Component({
  selector: 'app-per-type',
  templateUrl: './per-type.component.html',
  styleUrls: ['./per-type.component.css']
})
export class PerTypeComponent implements OnInit {

  serieData: SerieModel = {
        name: 'Publications Per Publication Type',
        type: 'pie',
        radius: [30, 110],
        roseType: 'area',
        data: [
          { value: 10, name: 'Books & Book Chapters/ Livres et Chapitres' },
          { value: 5, name: 'Consultant Report/ Raport de consultant' },
          { value: 15, name: 'Cost Recovery (CR) report / Rapport de recouvrement des coûts' },
          { value: 25, name: 'Journal/ Revue scientifique' },
          { value: 20, name: 'Other Publication/ Autres publications' },
          { value: 35, name: 'Poster/Affiche' },
          { value: 30, name: 'Presentation/Présentation' },
          { value: 40, name: 'Conference Proceedings/Actes de conférence' },
          { value: 40, name: 'Internal technical report/Rapport technique interne' }
        ]
  };
  theme = "";
  options = {
    title: {
      text: 'Publications Per Publication Type',
      subtext: '',
      x: 'center'
    },
    tooltip: {
      trigger: 'item',
      formatter: '{a} <br/>{b} : {c} ({d}%)'
    },
    legend: {
      x: 'center',
      y: 'bottom',
      data: ['Books & Book Chapters/ Livres et Chapitres', 'Consultant Report/ Raport de consultant', 'Cost Recovery (CR) report / Rapport de recouvrement des coûts', 'Journal/ Revue scientifique', 'Other Publication/ Autres publications', 'Poster / Affiche', 'Presentation/Présentation', 'Conference Proceedings / Actes de conférence', 'Internal technical report/Rapport technique interne']
    },
    calculable: true,
    series: this.serieData,
  };


  constructor() { }

  ngOnInit(): void {
  }

}
