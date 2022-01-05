import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AboutUsContentComponent } from './about-us-content.component';

describe('AboutUsContentComponent', () => {
  let component: AboutUsContentComponent;
  let fixture: ComponentFixture<AboutUsContentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AboutUsContentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AboutUsContentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
