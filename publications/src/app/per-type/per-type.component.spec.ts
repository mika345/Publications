import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PerTypeComponent } from './per-type.component';

describe('PerTypeComponent', () => {
  let component: PerTypeComponent;
  let fixture: ComponentFixture<PerTypeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PerTypeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PerTypeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
