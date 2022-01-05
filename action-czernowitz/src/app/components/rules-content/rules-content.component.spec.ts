import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RulesContentComponent } from './rules-content.component';

describe('RulesContentComponent', () => {
  let component: RulesContentComponent;
  let fixture: ComponentFixture<RulesContentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RulesContentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RulesContentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
