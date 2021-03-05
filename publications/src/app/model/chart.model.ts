
export class ChartModel {
  public data: SerieModel[];
  constructor(data: SerieModel[]) {
    {
      this.data = data;
    }}
}

export class SerieModel {
  public name: string;
  public type: string;
  public radius: [30, 110];
  public roseType: string;
  public data: SeriesChildModel[];
  constructor(name: string, type: string, radius: [30, 110], roseType: string, data: SeriesChildModel[]) {
    this.name = name;
    this.type = type;
    this.radius = radius;
    this.roseType = roseType;
    this.data = data;
  }
}

export class SeriesChildModel {
  public name: string;
  public value: number;
  constructor(name: string, value: number) {
    this.name = name;
    this.value = value;
  }
}
